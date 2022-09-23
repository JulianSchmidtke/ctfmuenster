import './MapControl.css';

import { MapContainer, Marker, Popup, TileLayer } from 'react-leaflet'
import { RouteComponentProps, withRouter } from 'react-router';
import React from 'react'
import { FlagService } from '../../services/FlagService';
import Flag from '../../models/Flag';
import { Guid } from 'guid-typescript'

type MapParams = { id: string }
type MapProps = RouteComponentProps<MapParams>;

type MapState = {
  lng_pos: number;
  lat_pos: number;
  zoom: number;
  flag: Flag | undefined;
  flag_exists: boolean;
}

class MapControl extends React.Component<MapProps, MapState>{
  state: MapState = {
    lng_pos: 51.9503535,
    lat_pos: 7.638635,
    zoom: 20,
    flag: undefined,
    flag_exists: false
  }

  componentDidMount(): void {
    var flagId = this.props.match.params.id;
    if (Guid.isGuid(flagId)) {
      FlagService.getFlag(flagId).then(flag => {
        this.setState({
          flag: flag,
          flag_exists: true
        })
      })
    }
  }

  render(): React.ReactNode {
    var { lng_pos, lat_pos, zoom, flag, flag_exists } = this.state
    return (
      <MapContainer style={{ height: "80vh", width: "100vw" }} center={[lng_pos, lat_pos]} zoom={zoom} >
        <TileLayer
          attribution='&copy; <a href="https://www.openstreetmap.org/copyright">OpenStreetMap</a> contributors'
          url="https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png"
        />
        {
          flag_exists && <Marker position={[flag.longitude, flag.latitude]} />
        }
      </MapContainer >
    )
  }
};

export default withRouter(MapControl);

import './MapControl.css';

import { MapContainer, Marker, Popup, TileLayer } from 'react-leaflet'
import { RouteComponentProps, withRouter } from 'react-router';
import React from 'react'
import { FlagService } from '../../services/FlagService';
import Flag from '../../models/Flag';
import { Icon } from './Icon';
import { Guid } from 'guid-typescript'
import L from 'leaflet';
import 'leaflet/dist/leaflet.css';

L.Marker.prototype.options.icon = Icon;

type MapParams = { id: string }
type MapProps = RouteComponentProps<MapParams>;

type MapState = {
  lng_pos: number;
  lat_pos: number;
  zoom: number;
  flag: Flag | undefined;
}

class MapControl extends React.Component<MapProps, MapState>{
  state: MapState = {
    lng_pos: 51.9503535,
    lat_pos: 7.638635,
    zoom: 12,
    flag: undefined
  }

  componentDidUpdate(prevProps: Readonly<MapProps>, prevState: Readonly<MapState>, snapshot?: any): void {
    if (prevProps.match != this.props.match) {
      let flagId = this.props.match.params.id;
      this.updateFlag(flagId)
    }
  }

  componentDidMount(): void {
    if ("geolocation" in navigator) {
      navigator.geolocation.watchPosition(function(position) {
        console.log("Latitude is :", position.coords.latitude);
        console.log("Longitude is :", position.coords.longitude);
        this.setState({
          lng_pos: position.coords.longitude,
          lat_pos: position.coords.latitude
        });
      });
    } else {
      console.log("Not Available");
    }
    let flagId = this.props.match.params.id;
    this.updateFlag(flagId)
  }

  updateFlag(flagId: string | undefined) {
    if (flagId && Guid.isGuid(flagId)) {
      FlagService.getFlag(flagId).then(flagObj => {
        this.setState({
          flag: flagObj
        })
      })
    } else {
      this.setState({
        flag: undefined
      })
    }
  }

  render(): React.ReactNode {
    var { lng_pos, lat_pos, zoom, flag } = this.state

    return (
      <MapContainer style={{ height: "60%", width: "100vw" }} center={[lng_pos, lat_pos]} zoom={zoom} >
        <TileLayer
          url="https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png"
        />
        {flag && <Marker position={[flag.location.longitude, flag.location.latitude]} ></Marker>}
        { lng_pos && lat_pos &&
          <Marker position={[lng_pos, lat_pos]} ></Marker>
        }

      </MapContainer >
    )
  }
};

export default withRouter(MapControl);

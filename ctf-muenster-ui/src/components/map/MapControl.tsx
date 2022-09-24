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
import icon from 'leaflet/dist/images/marker-icon.png';
import iconShadow from 'leaflet/dist/images/marker-shadow.png';

// let DefaultIcon = L.icon({
//   iconUrl: icon,
//   shadowUrl: iconShadow
// });

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

  // UNSAFE_componentWillUpdate(): void {
  //   let flagId = this.props.match.params.id;
  //   if (flagId) { this.updateFlag(flagId) }
  // }

  componentDidMount(): void {
    let flagId = this.props.match.params.id;
    if (flagId) { this.updateFlag(flagId) }
  }

  updateFlag(flagId: string) {
    if (Guid.isGuid(flagId)) {
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
    console.log(flag)
    if (!flag) {
      return (
        <MapContainer style={{ height: "100%", width: "100vw" }} center={[lng_pos, lat_pos]} zoom={zoom} >
          <TileLayer
            url="https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png"
          />
        </MapContainer >
      )
    }

    return (
      <MapContainer style={{ height: "60vh", width: "100vw" }} center={[lng_pos, lat_pos]} zoom={zoom} >
        <TileLayer
          url="https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png"
        />
        <Marker position={[flag.location.longitude, flag.location.latitude]} ></Marker>

      </MapContainer >
    )
  }
};

export default withRouter(MapControl);

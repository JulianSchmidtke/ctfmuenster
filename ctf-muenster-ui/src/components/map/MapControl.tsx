import './MapControl.css';

import { MapContainer, Marker, Popup, TileLayer } from 'react-leaflet'
import { RouteComponentProps, withRouter } from 'react-router';
import React from 'react'
import { FlagService } from '../../services/FlagService';
import Flag from '../../models/Flag';
import { MsFlagIcon, CircleIcon } from './Icon';
import { Guid } from 'guid-typescript'
import L from 'leaflet';
import 'leaflet/dist/leaflet.css';
import icon from 'leaflet/dist/images/marker-icon.png';
import iconShadow from 'leaflet/dist/images/marker-shadow.png';
import {
  IonContent, IonHeader, IonPage, IonTitle, IonToolbar, IonCard, IonItem,
  IonCardHeader, IonCardSubtitle, IonCardTitle, IonCardContent, IonLabel,
  IonButton, IonRippleEffect, IonIcon, IonChip, IonAlert, IonButtons, IonRedirect
} from '@ionic/react';
import { ellipsisVertical} from 'ionicons/icons';


const FlagIcon = MsFlagIcon
L.Marker.prototype.options.icon = CircleIcon;

type MapParams = { id: string }
type MapProps = RouteComponentProps<MapParams>;

type MapState = {
  lng_pos: number;
  lat_pos: number;
  zoom: number;
  flag: Flag | undefined;
  showAlert: boolean;
  captured: boolean;
}

class MapControl extends React.Component<MapProps, MapState>{
  state: MapState = {
    lng_pos: 51.9503535,
    lat_pos: 7.638635,
    zoom: 12,
    flag: undefined,
    showAlert: false,
    captured: false
  }

  componentDidUpdate(prevProps: Readonly<MapProps>, prevState: Readonly<MapState>, snapshot?: any): void {
    if (prevProps.match != this.props.match) {
      let flagId = this.props.match.params.id;
      this.setState({ captured: false })
      this.updateFlag(flagId)
    }
  }

  componentDidMount(): void {
    if ("geolocation" in navigator) {
      navigator.geolocation.watchPosition((position) => {
        this.setState({
          lng_pos: position.coords.latitude,
          lat_pos: position.coords.longitude
        });
      });
    } else {
      console.log("Not Available");
    }
    let flagId = this.props.match.params.id;
    this.updateFlag(flagId)
  }

  calcDistance(lon1, lon2, lat1, lat2) {
    const R = 6371e3; // metres
    const ??1 = lat1 * Math.PI / 180; // ??, ?? in radians
    const ??2 = lat2 * Math.PI / 180;
    const ???? = (lat2 - lat1) * Math.PI / 180;
    const ???? = (lon2 - lon1) * Math.PI / 180;

    const a = Math.sin(???? / 2) * Math.sin(???? / 2) +
      Math.cos(??1) * Math.cos(??2) *
      Math.sin(???? / 2) * Math.sin(???? / 2);
    const c = 2 * Math.atan2(Math.sqrt(a), Math.sqrt(1 - a));

    const d = R * c; // in metres
    return d
  }

  updateFlag(flagId: string | undefined) {
    if (flagId && Guid.isGuid(flagId)) {
      FlagService.getFlag(flagId).then(flagObj => {
        this.setState({
          flag: flagObj,
          zoom: 12
        })
      })
    } else {
      this.setState({
        flag: undefined,
        zoom: 12
      })
    }
  }

  render(): React.ReactNode {
    var { lng_pos, lat_pos, zoom, flag, showAlert, captured } = this.state

    if (!flag) {
      return (
        <MapContainer style={{ height: "100%", width: "100vw" }} center={[lng_pos, lat_pos]} zoom={zoom} >
          <TileLayer
            url="https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png"
          />
          {lng_pos && lat_pos &&
            <Marker position={[lng_pos, lat_pos]} ></Marker>
          }
        </MapContainer>
      )
    }

    let distance = this.calcDistance(lng_pos, flag.location.longitude, lat_pos, flag.location.latitude);
    console.log(distance)

    if (flag && !captured && distance < 20) {
      this.setState({ showAlert: true })
    }

    return (
      <>
        <IonAlert
          isOpen={showAlert}
          onDidDismiss={() => {
            this.setState({ showAlert: false, captured: true })
            FlagService.captureFlag(flag)
            this.props.history.push("/history");
          }
          }
          header="Flagge gefunden"
          message={flag.flagName}
          buttons={['Sammeln']}
        />

        <div style={{ height: "75%" }}>
          <MapContainer style={{ height: "100%", width: "100vw" }} center={[lng_pos, lat_pos]} zoom={zoom} >
            <TileLayer
              url="https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png"
            />
            <Marker position={[flag.location.longitude, flag.location.latitude]} icon={FlagIcon}></Marker>
            {lng_pos && lat_pos &&
              <Marker position={[lng_pos, lat_pos]}></Marker>
            }
          </MapContainer >
        </div>
        <IonCard>
          <IonCardHeader>
            <IonButtons style={{ float: "right" }}>
              <IonButton>
                <IonIcon icon={ellipsisVertical}></IonIcon>
              </IonButton>
            </IonButtons>
            <IonCardSubtitle>Jovel Flag</IonCardSubtitle>
            <IonCardTitle>{flag.flagName}</IonCardTitle>
          </IonCardHeader>

          <IonCardContent>
            <div className='info-text'>
              {flag.description}
            </div>
            Verf??gbar bis: {flag.dateTimeEndActive.toLocaleDateString("de-DE", { weekday: 'long', year: 'numeric', month: '2-digit', day: '2-digit' })} <br />
            {
              flag.tags.map(t => {
                return (
                  <IonChip key={t.id.toString()}>{t.name}</IonChip>
                );
              })
            }
          </IonCardContent>
        </IonCard>
      </>
    )
  }
};

export default withRouter(MapControl);

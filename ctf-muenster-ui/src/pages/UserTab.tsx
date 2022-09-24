import { 
  IonContent, IonHeader, IonPage, IonTitle, IonToolbar, IonCard, IonItem, 
  IonCardHeader, IonCardSubtitle, IonCardTitle, IonCardContent, IonLabel,
  IonButton, IonRippleEffect, IonIcon
} from '@ionic/react';
import HeaderContainer from '../components/HeaderContainer';
import { UserSerivce } from '../services/UserService';
import User from '../models/User';
import React,{ useState, useEffect } from 'react';
import Gravatar from 'react-gravatar';
import { Guid } from "guid-typescript";
import { flagOutline, medalOutline} from 'ionicons/icons';

import "./UserTab.css"

class UserTab extends React.Component {
  state = {
    userDetails: null,
    loading: true
  }

  componentDidMount() {
    this.setState({
      loading: true
    })

    UserSerivce.getUserDetails(UserSerivce.getStdUserId()).then(user => {
      this.setState({
        userDetails: user,
        loading: false
      })
    })
  }
  
  render() {
    const { userDetails, loading } = this.state;

    console.log(userDetails, loading)

    if (loading) {
      return (
        <IonPage>
          <HeaderContainer title="Benutzer" />
          <IonContent fullscreen>
            Loading
          </IonContent>
        </IonPage>
      )
    }

    return (
      <IonPage>
        <HeaderContainer title="Benutzer" />
        <IonContent fullscreen>

          <IonCard>
            <Gravatar email={`${userDetails.user.userName}@gmail.com`} size={512} default={"identicon"} className="user-icon" />
            <IonCardHeader>
              <IonCardSubtitle>Jovel Flag</IonCardSubtitle>
              <IonCardTitle>Persönliche Daten</IonCardTitle>
            </IonCardHeader>

            <IonCardContent> 
              ID: {userDetails.user.id} <br />
              Benutzername: {userDetails.user.userName}
            </IonCardContent>
          </IonCard>

          <IonCard>
            <IonCardHeader>
              <IonCardTitle>Statistik</IonCardTitle>
            </IonCardHeader>
              
            <IonCardContent> 
              Punkteanzahl: {userDetails.scoreCount | 0} <IonIcon icon={medalOutline}></IonIcon> <br />
              Gefundene Flaggen: {userDetails.flagCount | 0} <IonIcon icon={flagOutline}></IonIcon>
            </IonCardContent>
          </IonCard>

          <IonCard>
            <div className="ion-activatable ripple-parent">
              <IonCardHeader>
                <IonTitle>Flag Einreichen</IonTitle>
              </IonCardHeader>
              <IonRippleEffect></IonRippleEffect>
            </div>
          </IonCard>
        </IonContent>
      </IonPage>
    )
  };
}

export default UserTab;

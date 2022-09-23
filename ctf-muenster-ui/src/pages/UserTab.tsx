import { 
  IonContent, IonHeader, IonPage, IonTitle, IonToolbar, IonCard, IonItem, 
  IonCardHeader, IonCardSubtitle, IonCardTitle, IonCardContent, IonLabel
} from '@ionic/react';
import HeaderContainer from '../components/HeaderContainer';
import { UserSerivce } from '../services/UserService';
import User from '../models/User';
import React,{ useState, useEffect } from 'react';
import Gravatar from 'react-gravatar';
import { Guid } from "guid-typescript";

class UserTab extends React.Component {
  state = {
    userDetails: null,
    loading: false
  }

  componentDidMount() {
    this.setState({
      loading: true
    })

    UserSerivce.getUserDetails(Guid.parse("e59871b2-5970-4f04-b1cd-42a0796a5279")).then(user => {
      this.setState({
        userDetails: user,
        loading: false
      })
    })
  }
  
  render() {
    const { userDetails, loading } = this.state;

    console.log(userDetails, loading)

    if (!loading) {
      return (
        <IonPage>
          <HeaderContainer title="Benutzer" />
          <IonContent fullscreen>
          </IonContent>
        </IonPage>
      )
    }

    

    return (
      <IonPage>
        <HeaderContainer title="Benutzer" />
        <IonContent fullscreen>

          <IonCard>
            <Gravatar email={`${userDetails.user.userName}@gmail.com`} size={512} default={"identicon"} style={{aspectRatio: 1, height: "auto"}} />
            <IonCardHeader>
              <IonCardSubtitle>Jovel Flag</IonCardSubtitle>
              <IonCardTitle>Persönliche Daten</IonCardTitle>
            </IonCardHeader>

            <IonCardContent> 
              {
                `ID: ${userDetails.user.id}\n Benutzername: ${userDetails.user.userName}`
              }
            </IonCardContent>
          </IonCard>

          <IonCard>
            <IonCardHeader>
              <IonCardTitle>Statistik</IonCardTitle>
            </IonCardHeader>
              
            <IonCardContent> 
              {
                `Anzahl Punkte: ${userDetails.score}\n Gefundene Flags: ${userDetails.flagcount}`
              }
            </IonCardContent>
          </IonCard>
        </IonContent>
      </IonPage>
    )
  };
}

export default UserTab;

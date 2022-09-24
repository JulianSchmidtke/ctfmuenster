import { IonContent, IonHeader, IonPage, IonTitle, IonToolbar, IonGrid, IonRow, IonCol, IonIcon } from '@ionic/react';
import React, { useState, BaseSyntheticEvent, useEffect } from 'react';
import ExploreContainer from '../components/ExploreContainer';
import HeaderContainer from '../components/HeaderContainer';
import './LeaderboardContainer.css';
import Gravatar from 'react-gravatar'
import User from '../models/User'
import { UserSerivce } from '../services/UserService';

import { flagOutline, medalOutline } from 'ionicons/icons';




function profiles(data: any) {
  return (
    <div id="profile">
      {Item(data)}
    </div>
  )
}


function Item(data: any) {
  return (
    <>
      {
        data.map((value, index) => (
          <IonRow key={index} className="col-border">
            <IonCol className='centerText'>#{index + 1}</IonCol>
            <IonCol>
              <Gravatar className='userIcon' email={value.user.userName + '@gmail.com'} default={"identicon"}/>
            </IonCol>
            <IonCol className='centerText'>{value.user.userName}</IonCol>
            <IonCol className='centerText'>{value.scoreCount} <IonIcon icon={medalOutline}></IonIcon></IonCol>
            <IonCol className='centerText'>{value.flagCount} <IonIcon icon={flagOutline}></IonIcon></IonCol>
          </IonRow>
        ))
      }
    </>
  )
}

class LeaderboardContainer extends React.Component {
  state =
    {
      leaderBoard: [],
      loading: false,
      period: 0
      // user: User,
      // scoreCount: number,
      // flagCount: number
    };

  fetchScores(dt?: Date) {
    UserSerivce.getScores(dt)
      .then((res) => {
        this.setState({
          leaderBoard: res
        })
      }
      );
  }



  componentDidMount() {
    this.setState({
      loading: true
    })
    this.fetchScores()
  }


  handleClick = (period: number) => {
    if(period === 0){
      this.fetchScores();
    }
    
  }

  render() {
    const { leaderBoard, loading } = this.state;

    return (
      <div className="board" >
        <h1 className='leaderboard'>Rangliste</h1>

        <div className="duration">
          <button onClick={() => this.handleClick(1)}>1 Tag</button>
          <button onClick={() => this.handleClick(7)}>7 Tage</button>
          <button onClick={() => this.handleClick(30)}>30 Tage</button>
          <button onClick={() => this.handleClick(0)}>Immer</button>
        </div>


        <div id="profile">
          <IonGrid>
            <IonRow className="col-header col-border">
              <IonCol>Rang</IonCol>
              <IonCol></IonCol>
              <IonCol>Name</IonCol>
              <IonCol>Punkte</IonCol>
              <IonCol>Flags</IonCol>
            </IonRow>
            {Item((leaderBoard))}
          </IonGrid>
        </div>

      </div>
    );
  }


};

export default LeaderboardContainer;
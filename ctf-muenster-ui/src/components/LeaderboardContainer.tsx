import { IonContent, IonHeader, IonPage, IonTitle, IonToolbar, IonGrid, IonRow, IonCol } from '@ionic/react';
import React, { useState, BaseSyntheticEvent, useEffect } from 'react';
import ExploreContainer from '../components/ExploreContainer';
import HeaderContainer from '../components/HeaderContainer';
import './LeaderboardContainer.css';
import Gravatar from 'react-gravatar'
import User from '../models/User'
import { UserSerivce } from '../services/UserService';



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
                    <IonRow key={index}>
                        <IonCol>{index}</IonCol>
                        <IonCol>
                            <Gravatar className='userIcon' email={value.user.userName + '@gmail.com'} />
                            <br />
                            {value.user.userName}
                        </IonCol>
                        <IonCol>{value.scoreCount}</IonCol>
                        <IonCol>{value.flagCount}</IonCol>
                    </IonRow>

                )
                )
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

    fetchUser() {
        UserSerivce.getScores()
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

        this.fetchUser()
    }


    handleClick = (period: number) => {
        this.setState({ period: period })
    }

    render() {
        const { leaderBoard, loading } = this.state;

        return(
            <div className = "board" >
                <h1 className='leaderboard'>Rangliste</h1>
    
                <div className="duration">
                    <button onClick={() => this.handleClick(1)}>1 Tag</button>
                    <button onClick={() => this.handleClick(7)}>7 Tage</button>
                    <button onClick={() => this.handleClick(30)}>30 Tage</button>
                    <button onClick={() => this.handleClick(0)}>Immer</button>
                </div>
    
    
                <div id="profile">
                    <IonGrid>
                        <IonRow className = "col-header">
                            <IonCol>Rang</IonCol>
                            <IonCol>Name</IonCol>
                            <IonCol>Punkte</IonCol>
                            <IonCol>Flags</IonCol>
                        </IonRow>
                    </IonGrid>
                    {Item((leaderBoard))}
                </div>
    
            </div>
        );
    }

    
};

export default LeaderboardContainer;
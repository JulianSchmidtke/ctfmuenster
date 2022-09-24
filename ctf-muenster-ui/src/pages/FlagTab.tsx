import { IonContent, IonHeader, IonPage, IonTitle, IonToolbar } from '@ionic/react';
import React, { useEffect, useState } from "react";
import './FlagTab.css';


import HeaderContainer from '../components/HeaderContainer';
import FlagCard from '../components/flag/FlagCard';
import { FlagService } from '../services/FlagService';

class FlagTab extends React.Component {
  state = {
    flags: [],
    loading: false
  }

  componentDidMount() {
    this.setState({
      loading: true
    })

    FlagService.getFlags().then(flags => {
      this.setState({
        flags: flags,
        loading: false
      })
    })
  }

  render() {
    const { flags, loading } = this.state;

    return (
      <IonPage>
        <HeaderContainer title="Flaggen" />
        <IonContent fullscreen>
          
          {!loading && flags.map((flag) => <FlagCard key={flag.id} flag={flag} />)}
        </IonContent>
      </IonPage>
    )
  };
};

export default FlagTab;

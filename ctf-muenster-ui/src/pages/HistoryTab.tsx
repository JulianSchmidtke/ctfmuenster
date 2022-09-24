import React, { useState, useEffect } from 'react';
import { IonContent, IonHeader, IonPage, IonTitle, IonToolbar } from '@ionic/react';
import './HistoryTab.css';

import HistoryEntryControl from '../components/HistoryEntryControl';
import { HistoryEntryProps } from '../components/HistoryEntryControl';
import HeaderContainer from '../components/HeaderContainer';
import UserFlag from '../models/UserFlag';
import { UserSerivce } from '../services/UserService';
import { FlagService } from '../services/FlagService';
import { Guid } from "guid-typescript";
/*
        
*/
const HistoryTab: React.FC = () => {
  const [historyEntryControls, setHistoryEntryControls] = useState(null);

  useEffect(() => {
    const fetchData = async () => {
      const userFlags: UserFlag[] = await UserSerivce.getUserFlags(UserSerivce.getStdUserId())
      console.log(userFlags)
      let historyEntryControlsTemp: JSX.Element[] = [];

      for (let i = 0; i < userFlags.length; i++) {
        const flag = await FlagService.getFlag(userFlags[i].flagId);

        historyEntryControlsTemp.push(<HistoryEntryControl key={i} userFlag={userFlags[i]} flag={flag}/>);
      }

      setHistoryEntryControls(historyEntryControlsTemp);
    };
  
    fetchData();
  }, []);

  return (
    <IonPage>
      <HeaderContainer title="Erfolge" />
      <IonContent fullscreen>

        <div className='historyEntries'>
          {historyEntryControls}
        </div>
      </IonContent>
    </IonPage>
  );
}

export default HistoryTab;

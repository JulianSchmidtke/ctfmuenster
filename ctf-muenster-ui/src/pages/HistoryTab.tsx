import React, { useState, useEffect } from 'react';
import { IonContent, IonHeader, IonPage, IonTitle, IonToolbar } from '@ionic/react';
import './HistoryTab.css';

import HistoryEntryControl from '../components/HistoryEntryControl';
import HeaderContainer from '../components/HeaderContainer';
import UserFlag from '../models/UserFlag';
import { UserSerivce } from '../services/UserService';
import { Guid } from "guid-typescript";
/*
        
*/
const HistoryTab: React.FC = () => {

  const [historyEntryControls, setHistoryEntryControls] = useState(null);

  useEffect(() => {
    const fetchData = async () => {
      const userFlags: UserFlag[] = await UserSerivce.getUserFlags(Guid.parse("e59871b2-5970-4f04-b1cd-42a0796a5279"))

      let historyEntryControlsTemp: JSX.Element[] = [];
      let i = 0;
      userFlags.forEach(userFlag => {
        historyEntryControlsTemp.push(<HistoryEntryControl key={i++} userFlag={userFlag}/>);
      });

      setHistoryEntryControls(historyEntryControlsTemp);
    };

    fetchData();
  }, []);

  return (
    <IonPage>
      <HeaderContainer title="History" />
      <IonContent fullscreen>
        <IonHeader collapse="condense">
          <IonToolbar>
            <IonTitle size="large">History</IonTitle>
          </IonToolbar>
        </IonHeader>

        <div className='historyEntries'>
          {historyEntryControls}
        </div>
        

      </IonContent>
    </IonPage>
  );
};

export default HistoryTab;

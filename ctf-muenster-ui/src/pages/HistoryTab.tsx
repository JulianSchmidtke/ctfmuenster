import { IonContent, IonHeader, IonPage, IonTitle, IonToolbar } from '@ionic/react';
import './HistoryTab.css';

import HistoryEntryControl from '../components/HistoryEntryControl';
import HeaderContainer from '../components/HeaderContainer';
/*
        
*/
const HistoryTab: React.FC = () => {

  let controls: JSX.Element[] = [];

  for (let index = 0; index < 10; index++) {
    controls.push(<HistoryEntryControl historyEntry={{userId: 1, flagId: 1, dateTime: new Date()}}/>);
    
  }

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
          {controls}
        </div>
        

      </IonContent>
    </IonPage>
  );
};

export default HistoryTab;

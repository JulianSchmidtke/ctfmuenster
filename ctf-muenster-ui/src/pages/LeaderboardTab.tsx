import { IonContent, IonHeader, IonPage, IonTitle, IonToolbar, IonGrid, IonRow, IonCol } from '@ionic/react';
import HeaderContainer from '../components/HeaderContainer';
import LeaderboardContainer from '../components/LeaderboardContainer';
const LeaderboardTab: React.FC = () => {
  

  return (
    
    <IonPage>
      <HeaderContainer title="Rangliste" />
      <IonContent fullscreen>
        <IonHeader collapse="condense">
          <IonToolbar>
            <IonTitle size="large">Rangliste</IonTitle>
          </IonToolbar>
        </IonHeader>
        <LeaderboardContainer/>
      </IonContent>
    </IonPage>
  );
};

export default LeaderboardTab;

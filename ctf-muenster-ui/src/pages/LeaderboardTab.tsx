import { IonContent, IonHeader, IonPage, IonTitle, IonToolbar, IonGrid, IonRow, IonCol } from '@ionic/react';
import HeaderContainer from '../components/HeaderContainer';
import LeaderboardContainer from '../components/LeaderboardContainer';
const LeaderboardTab: React.FC = () => {
  

  return (
    
    <IonPage>
      <HeaderContainer title="Rangliste" />
      <IonContent fullscreen>
        <LeaderboardContainer/>
      </IonContent>
    </IonPage>
  );
};

export default LeaderboardTab;

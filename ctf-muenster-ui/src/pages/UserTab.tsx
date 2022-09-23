import { IonContent, IonHeader, IonPage, IonTitle, IonToolbar } from '@ionic/react';
import HeaderContainer from '../components/HeaderContainer';


const UserTab: React.FC = () => {
  return (
    <IonPage>
      <HeaderContainer title="Benutzer" />
      <IonContent fullscreen>
        <IonHeader collapse="condense">
          <IonToolbar>
            <IonTitle size="large">Tab 1</IonTitle>
          </IonToolbar>
        </IonHeader>
      </IonContent>
    </IonPage>
  );
};

export default UserTab;

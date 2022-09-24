import './HeaderContainer.css';
import { IonContent, IonHeader, IonPage, IonTitle, IonToolbar, IonIcon, IonButton, IonButtons } from '@ionic/react';
import { personCircleOutline } from 'ionicons/icons';


interface ContainerProps {
  title: string;
}

const HeaderContainer: React.FC<ContainerProps> = ({ title }) => {
  return (
    <IonHeader>
      <IonToolbar>
          <IonButtons>
            <IonButton routerLink="/user">
              <IonIcon slot="icon-only" icon={personCircleOutline}></IonIcon>
            </IonButton>
          </IonButtons>
        
        <IonTitle>{title}</IonTitle>
      </IonToolbar>
    </IonHeader>
  );
};

export default HeaderContainer;
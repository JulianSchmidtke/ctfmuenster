import './HeaderContainer.css';
import { IonContent, IonHeader, IonPage, IonTitle, IonToolbar } from '@ionic/react';

interface ContainerProps {
  title: string;
}

const HeaderContainer: React.FC<ContainerProps> = ({ title }) => {
  return (
    <IonHeader>
    <IonToolbar>
      <IonTitle>{title}</IonTitle>
    </IonToolbar>
  </IonHeader>
  );
};

export default HeaderContainer;
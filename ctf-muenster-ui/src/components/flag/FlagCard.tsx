import { IonCard, IonCardHeader, IonCardTitle, IonCardContent } from '@ionic/react';
import Flag from "../../models/Flag";

interface ContainerProps {
  flag: Flag;
}

const FlagCard: React.FC<ContainerProps> = ({ flag }) => {
  return (
    <IonCard routerLink={`/map/${flag.id}`}>
      <IonCardHeader>
        <IonCardTitle>{flag.flagName}</IonCardTitle>
      </IonCardHeader>

      <IonCardContent>{flag.description}</IonCardContent>
      <IonCardContent>Ende: {flag.dateTimeEndActive.toString()}</IonCardContent>
    </IonCard>
  );
};

export default FlagCard;

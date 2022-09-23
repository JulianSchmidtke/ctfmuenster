import { IonCard, IonCardHeader, IonCardTitle, IonCardContent, IonChip } from '@ionic/react';
import Flag from "../../models/Flag";

interface ContainerProps {
  flag: Flag;
}

const FlagCard: React.FC<ContainerProps> = ({ flag }) => {
  console.log(flag)

  return (
    <IonCard routerLink={`/map/${flag.id}`}>
      <IonCardHeader>
        <IonCardTitle>{flag.flagName}</IonCardTitle>
      </IonCardHeader>
      
      <IonCardContent>
        {flag.description} <br />
        Ende: {flag.dateTimeEndActive.toLocaleDateString("de-DE", { weekday: 'long', year: 'numeric', month: '2-digit', day: '2-digit'})} <br />
        {
          flag.tags.map(t => {
            return (
              <IonChip>{t}</IonChip>
            );
          })
        }
      </IonCardContent>
    </IonCard>
  );
};

export default FlagCard;

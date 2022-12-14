import { IonCard, IonCardHeader, IonCardTitle, IonCardContent, IonChip } from '@ionic/react';
import Flag from "../../models/Flag";
import './FlagCard.css';

interface ContainerProps {
  flag: Flag;
}

const FlagCard: React.FC<ContainerProps> = ({ flag }) => {
  return (
    <IonCard routerLink={`/map/${flag.id}`}>
      
      <div style={{display: 'flex'}}>
        <IonCardHeader>
          <IonCardTitle>{flag.flagName}</IonCardTitle>
        </IonCardHeader>

        <div className='flagIconFull'>
          <img src={flag.imageFileName} style={{borderRadius: "5px"}} />
        </div>

        
      </div>
      

      <IonCardContent>
        <p style={{textOverflow: "ellipsis", whiteSpace: "nowrap", overflow: "hidden", width: "70%"}}>{flag.description}</p>
        Ende: {flag.dateTimeEndActive.toLocaleDateString("de-DE", { weekday: 'long', year: 'numeric', month: '2-digit', day: '2-digit'})} <br />
        {
          flag.tags.map(t => {
            return (
              <IonChip key={t.id.toString()}>{t.name}</IonChip>
            );
          })
        }
      </IonCardContent>
    </IonCard>
  );
};

export default FlagCard;

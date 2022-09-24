import './HistoryEntryControl.css';
import UserFlag from '../models/UserFlag';
import { IonIcon } from '@ionic/react';
import { flagOutline, medalOutline } from 'ionicons/icons';
import Flag from '../models/Flag';


export interface HistoryEntryProps {
  userFlag: UserFlag;
  flag: Flag
}

const HistoryEntryControl: React.FC<HistoryEntryProps> = props => {

  
  //console.log(props.userFlag);
  let { userFlag, flag} = props;

  let date = new Date(userFlag.dateTimeCollected);

  return (
    <div className="historyEntry">
      <div style={{display: 'flex'}}>
        <div className='flagIcon'>
          <img src={flag.imageFileName} style={{borderRadius: "5px"}} />
        </div>
        <div className='flagName'>{flag.flagName}</div>
        <div className='captured' style={{flex: 1, textAlign: 'end', marginTop: 5}}>Gesammelt!</div>
      </div>
      
      <div style={{display: 'flex'}}>
        
        <div className='points'>{userFlag.score}</div>
        <IonIcon style={{marginTop: '10px', marginLeft: '3px'}} icon={medalOutline}></IonIcon>
        <div style={{display: 'flex', justifyContent: 'end', flex: 1, marginTop: '10px'}}>
          <IonIcon icon={flagOutline}></IonIcon>
          <div className='dateTime'>
            {date.toLocaleDateString("de-DE", { weekday: 'long', year: 'numeric', month: '2-digit', day: '2-digit'})}
          </div>
        </div>
      </div>
     
      
    </div>
  );
};

export default HistoryEntryControl;
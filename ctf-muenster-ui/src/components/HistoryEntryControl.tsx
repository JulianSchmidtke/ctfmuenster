import './HistoryEntryControl.css';
import UserFlag from '../models/UserFlag';
import { IonIcon } from '@ionic/react';
import { flagOutline } from 'ionicons/icons';


export interface HistoryEntryProps {
  userFlag: UserFlag;
  //flagName: string;
}

const HistoryEntryControl: React.FC<HistoryEntryProps> = props => {

  
  console.log(props.userFlag);
  let { userFlag } = props;

  let date = new Date(userFlag.dateTimeCollected);

  return (
    <div className="historyEntry">
      <div style={{display: 'flex'}}>
        <div className='flagIcon'></div>
        <div className='flagName'>{""}</div>
        <div className='captured' style={{flex: 1, textAlign: 'end', marginTop: 5}}>Captured!</div>
      </div>
      
      <div style={{display: 'flex'}}>
        
        <div className='points'>{userFlag.score}</div>
        <div style={{marginTop: '12px', marginLeft: '3px'}}>Punkte</div>
        <div style={{display: 'flex', justifyContent: 'end', flex: 1, marginTop: '10px'}}>
          <IonIcon icon={flagOutline}></IonIcon>
          <div className='dateTime'>
            {date.getDay() + '.' + date.getMonth() + '.' + date.getFullYear()}
          </div>
        </div>
      </div>
     
      
    </div>
  );
};

export default HistoryEntryControl;
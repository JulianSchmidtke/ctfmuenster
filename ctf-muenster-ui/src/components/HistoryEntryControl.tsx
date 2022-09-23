import './HistoryEntryControl.css';
import UserFlag from '../models/UserFlag';

export interface HistoryEntryProps {
  userFlag: UserFlag;
}

const HistoryEntryControl: React.FC<HistoryEntryProps> = () => {

  let date = new Date();

  return (
    <div className="historyEntry">
      <div style={{display: 'flex'}}>
        <div className='flagIcon'></div>
        <div className='flagName'>Flag name</div>
        <div className='captured' style={{flex: 1, textAlign: 'end', marginTop: 5}}>Captured!</div>
      </div>
      
      <div style={{display: 'flex'}}>
        
        <div className='points'>50</div>
        <div style={{marginTop: '12px', marginLeft: '3px'}}>Punkte</div>
        <div style={{display: 'flex', justifyContent: 'end', flex: 1, marginTop: '10px'}}>
          <div className='flagMiniIcon'></div>
          <div className='dateTime'>
            {date.getDay() + '.' + date.getMonth() + '.' + date.getFullYear()}
          </div>
        </div>
      </div>
     
      
    </div>
  );
};

export default HistoryEntryControl;
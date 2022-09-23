import './HistoryEntryControl.css';
import HistoryEntry from '../models/HistoryEntry';

export interface HistoryEntryProps {
  historyEntry: HistoryEntry;
}

const HistoryEntryControl: React.FC<HistoryEntryProps> = () => {
  return (
    <div className="historyEntry">
      <div>Flag name</div>
      <div>User</div>
      <div>{new Date().toUTCString()}</div>
    </div>
  );
};

export default HistoryEntryControl;
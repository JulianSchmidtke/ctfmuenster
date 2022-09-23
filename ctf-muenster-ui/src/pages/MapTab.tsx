import { IonContent, IonHeader, IonPage, IonTitle, IonToolbar } from '@ionic/react';
import ExploreContainer from '../components/ExploreContainer';
import HeaderContainer from '../components/HeaderContainer';
import MapContainer from '../components/MapContainer';

import './MapTab.css';

const MapTab: React.FC = () => {
  const mapIsReadyCallback = (map:any) => {
    console.log(map);
  };

  return (
    <IonPage>
      <HeaderContainer title="Map" />
      <IonContent fullscreen>
        <IonHeader collapse="condense">
          <IonToolbar>
            <IonTitle size="large">Tab 1</IonTitle>
          </IonToolbar>
        </IonHeader>
        {/* <MapContainer/> */}
      </IonContent>
    </IonPage>
  );
};

export default MapTab;

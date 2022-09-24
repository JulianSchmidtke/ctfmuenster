import { IonContent, IonHeader, IonPage, IonTitle, IonToolbar } from '@ionic/react';
import ExploreContainer from '../components/ExploreContainer';
import HeaderContainer from '../components/HeaderContainer';
import MapControl from '../components/map/MapControl';

import './MapTab.css';

const MapTab: React.FC = () => {
  const mapIsReadyCallback = (map:any) => {
    console.log(map);
  };

  return (
    <IonPage>
      <HeaderContainer title="Karte" />
      <IonContent fullscreen>
        <MapControl/>
      </IonContent>
    </IonPage>
  );
};

export default MapTab;

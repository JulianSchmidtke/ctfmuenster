import { Redirect, Route } from 'react-router-dom';
import {
  IonApp,
  IonIcon,
  IonLabel,
  IonRouterOutlet,
  IonTabBar,
  IonTabButton,
  IonTabs,
  setupIonicReact
} from '@ionic/react';
import { IonReactRouter } from '@ionic/react-router';
import { mapOutline, trophyOutline, listOutline, flagOutline } from 'ionicons/icons';
import MapTab from './pages/MapTab';
import HistoryTab from './pages/HistoryTab';
import LeaderboardTab from './pages/LeaderboardTab';
import UserTab from './pages/UserTab';
import FlagTab from './pages/FlagTab';

/* Core CSS required for Ionic components to work properly */
import '@ionic/react/css/core.css';

/* Basic CSS for apps built with Ionic */
import '@ionic/react/css/normalize.css';
import '@ionic/react/css/structure.css';
import '@ionic/react/css/typography.css';

/* Optional CSS utils that can be commented out */
import '@ionic/react/css/padding.css';
import '@ionic/react/css/float-elements.css';
import '@ionic/react/css/text-alignment.css';
import '@ionic/react/css/text-transformation.css';
import '@ionic/react/css/flex-utils.css';
import '@ionic/react/css/display.css';

/* Theme variables */
import './theme/variables.css';

setupIonicReact();

const App: React.FC = () => (
  <IonApp>
    <IonReactRouter>
      <IonTabs>
        <IonRouterOutlet>
          <Route path="/flags">
            <FlagTab />
          </Route>
          <Route path="/map/:id">
            <MapTab />
          </Route>
          <Route path="/leaderboard">
            <LeaderboardTab />
          </Route>
          <Route path="/history">
            <HistoryTab />
          </Route>
          <Route path="/user">
            <UserTab />
          </Route>
          <Route exact path="/">
            <Redirect to="/flags" />
          </Route>
        </IonRouterOutlet>

        <IonTabBar slot="bottom">
          <IonTabButton tab="Flags" href="/flags">
            <IonIcon icon={flagOutline} />
            <IonLabel>Flags</IonLabel>
          </IonTabButton>
          <IonTabButton tab="map" href="/map">
            <IonIcon icon={mapOutline} />
            <IonLabel>Karte</IonLabel>
          </IonTabButton>
          <IonTabButton tab="leaderboard" href="/leaderboard">
            <IonIcon icon={trophyOutline} />
            <IonLabel>Rangliste</IonLabel>
          </IonTabButton>
          <IonTabButton tab="history" href="/history">
            <IonIcon icon={listOutline} />
            <IonLabel>History</IonLabel>
          </IonTabButton>
        </IonTabBar>
      </IonTabs>
    </IonReactRouter>
  </IonApp>
);

export default App;

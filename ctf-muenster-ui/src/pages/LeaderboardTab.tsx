import { IonContent, IonHeader, IonPage, IonTitle, IonToolbar } from '@ionic/react';
import { useState, BaseSyntheticEvent } from 'react';
import ExploreContainer from '../components/ExploreContainer';
import HeaderContainer from '../components/HeaderContainer';
import './LeaderboardTab.css';

type Leaderboard = [
  {
      name: "Shawn Hanna",
      location: "India",
      score : 1550,
      img: "https://images.unsplash.com/photo-1494790108377-be9c29b29330?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=facearea&facepad=4&w=256&h=256&q=60",
      dt: "2022-02-10"
  },
  {
      name: "Fidel Hand",
      location: "USA",
      score : 2310,
      img: "https://images.unsplash.com/photo-1500648767791-00dcc994a43e?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=facearea&facepad=4&w=256&h=256&q=60",
      dt: "2021-01-01"
  },
  {
      name: "Bessie Hickle",
      location: "Chaina",
      score : 350,
      img: "https://images.unsplash.com/photo-1534528741775-53994a69daeb?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=facearea&facepad=4&w=256&h=256&q=60",
      dt: "2021-08-17"
  },
  {
      name: "Adella Wunsch",
      location: "Japan",
      score : 2100,
      img: "https://images.unsplash.com/photo-1570295999919-56ceb5ecca61?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=facearea&facepad=4&w=256&h=256&q=60",
      dt: "2021-10-23"
  },
  {
      name: "Clair O'Connell",
      location: "London",
      score : 1250,
      img: "https://images.unsplash.com/photo-1507003211169-0a1dd7228f2d?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=facearea&facepad=4&w=256&h=256&q=60",
      dt: "2022-01-22"
  },
  {
      name: "Kameron Prosacco",
      location: "Canada",
      score : 5250,
      img: "https://images.unsplash.com/photo-1487412720507-e7ab37603c6f?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=facearea&facepad=4&w=256&h=256&q=60",
      dt: "2022-01-21"
  }
]

function profiles(data: Leaderboard) {
  return (
        <div id="profile">
            {Item(data)}
        </div>
  )
}


function Item(data: Leaderboard){
  return (

      <>
          {
              data.map((value, index) => (
                  <div className="flex" key={index}>
                      <div className="item">
                          <img src={value.img} alt="" />
          
                          <div className="info">
                              <h3 className='name text-dark'>{value.name}</h3>    
                          </div>                
                      </div>
                      <div className="item">
                          <span>{value.score}</span>
                      </div>
                  </div>
                  )
              )
          }
      </>

      
  )
}

/*const [period, setPeriod] = useState(0);

  const handleClick = (e: BaseSyntheticEvent) => {
     
    setPeriod(e.target.dataset.id)
  }
*/

const LeaderboardTab: React.FC = () => {
  return (
    
    <IonPage>
      <HeaderContainer title="Rangliste" />
      <IonContent fullscreen>
        <IonHeader collapse="condense">
          <IonToolbar>
            <IonTitle size="large">Tab 2</IonTitle>
          </IonToolbar>
        </IonHeader>
        <ExploreContainer name="Tab 2 page" />
      </IonContent>
    </IonPage>
  );
};

export default LeaderboardTab;

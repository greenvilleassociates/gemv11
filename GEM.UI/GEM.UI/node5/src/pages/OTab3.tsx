import { IonContent, IonHeader, IonPage, IonTitle, IonToolbar } from '@ionic/react';
import ExploreContainer from '../components/ExploreContainer';
import './Tab3.css';
import '../theme/customcolors.css';

const Tab3: React.FC = () => {
  return (
    <IonPage>
      <IonHeader>
        <IonToolbar color="tertiary">
          <IonTitle>@GreenvilleAssociates</IonTitle>
        </IonToolbar>
      </IonHeader>
      <IonContent fullscreen>
        <IonHeader collapse="condense">
          <IonToolbar>
            <IonTitle size="large">@Apps</IonTitle>
          </IonToolbar>
        </IonHeader>
        <ExploreContainer name="GEM-Apps" />
      </IonContent>
    </IonPage>
  );
};

export default Tab3;

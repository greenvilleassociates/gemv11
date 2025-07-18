import { IonContent, IonHeader, IonPage, IonTitle, IonToolbar } from '@ionic/react';
import ExploreContainer from '../components/ExploreContainer';
import './Tab2.css';
import '../theme/customcolors.css';

const Tab2: React.FC = () => {
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
            <IonTitle size="large">@GEM-Work</IonTitle>
          </IonToolbar>
        </IonHeader>
        <ExploreContainer name="GEM Workflow" />
      </IonContent>
    </IonPage>
  );
};

export default Tab2;

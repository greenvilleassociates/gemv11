import { IonContent, IonHeader, IonPage, IonTitle, IonToolbar } from '@ionic/react';
import ExploreContainer from '../components/ExploreContainer';
import './Tab1.css';
import '../theme/customcolors.css';

const Tab1: React.FC = () => {
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
            <IonTitle size="large">Executive Information System</IonTitle>
          </IonToolbar>
        </IonHeader>
        <ExploreContainer name="@GEM-EIS" />
      </IonContent>
    </IonPage>
  );
};

export default Tab1;

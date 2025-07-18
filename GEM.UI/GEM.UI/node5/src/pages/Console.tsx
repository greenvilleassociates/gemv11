import { IonButtons, IonContent, IonHeader, IonMenuButton, IonPage, IonTitle, IonToolbar, IonAlert, IonCard, IonButton } from '@ionic/react';
import { useParams } from 'react-router';
import '../theme/customcolors.css';
import '../pages/Console.css';
import Iframe from 'react-iframe';

const Console: React.FC = () => {

  const { name } = useParams<{ name: string; }>();

  return (
    <IonPage>
	
      <IonHeader>
        <IonToolbar color = "tertiary">
          <IonButtons slot="start">
            <IonMenuButton />
          </IonButtons>
          <IonTitle text-right>@GreenvilleAssociates</IonTitle>
        </IonToolbar>
      </IonHeader>

      <IonContent fullscreen>
        <IonHeader collapse="condense">
          <IonToolbar color = "danger"><IonTitle>@Unified</IonTitle>
           </IonToolbar>
        </IonHeader>
        <Iframe url="https://gridmanager5.590team1.info/fusionsso/gaconsole/index.aspx"
        width="100%"
        height="1000px"
        id=""
        className=""
        display="block"
        position="relative"/>
      </IonContent>
    </IonPage>
  );
};

export default Console;

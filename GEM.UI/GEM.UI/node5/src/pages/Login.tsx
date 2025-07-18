import { IonButtons, IonContent, IonHeader, IonMenuButton, IonPage, IonTitle, IonToolbar, IonAlert, IonCard, IonButton } from '@ionic/react';
import { useParams } from 'react-router';
import '../theme/customcolors.css';
import Iframe from 'react-iframe';
import './Login.css';

const Login: React.FC = () => {
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
          <IonToolbar color = "danger"><IonTitle>@Login</IonTitle>
           </IonToolbar>
        </IonHeader>
        <Iframe url="https://gridmanager5.590team1.info/fusionpro/h/index.php/component/users/?view=login&Itemid=101"
        width="100%"
        height="1200px"
        id=""
        className=""
        display="block"
        position="relative"/>
      </IonContent>
</IonPage>
);
};

export default Login;

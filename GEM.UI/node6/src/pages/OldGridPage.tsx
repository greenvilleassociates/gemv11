import React, { useState, useEffect } from "react";
import { IonPage, IonHeader, IonToolbar, IonTitle, IonContent, IonGrid, IonRow, IonCol, IonCard, IonCardContent } from "@ionic/react";

const GridPage: React.FC = () => {
  const [databaseNodes, setDatabaseNodes] = useState<string[]>([]);
  const [webServerNodes, setWebServerNodes] = useState<string[]>([]);

  useEffect(() => {
    fetch("https://gridactions3b.590team1.info/LinuxConsole/3")
      .then(response => response.json())
      .then(data => {
        setDatabaseNodes(data.databaseNodes || []);
        setWebServerNodes(data.webServerNodes || []);
      })
      .catch(error => console.error("Error fetching data:", error));
  }, []);

  return (
    <IonPage>
      <IonHeader>
        <IonToolbar>
          <IonTitle>Hosts Grid</IonTitle>
        </IonToolbar>
      </IonHeader>
      <IonContent className="ion-padding">
        <IonGrid>
          <IonRow>
            <IonCol>
              <IonCard>
                <IonCardContent>
                  <h3>Database Nodes</h3>
                  {databaseNodes.map((node, index) => (
                    <p key={index}>{node}</p>
                  ))}
                </IonCardContent>
              </IonCard>
            </IonCol>
            <IonCol>
              <IonCard>
                <IonCardContent>
                  <h3>Web Server Nodes</h3>
                  {webServerNodes.map((node, index) => (
                    <p key={index}>{node}</p>
                  ))}
                </IonCardContent>
              </IonCard>
            </IonCol>
          </IonRow>
        </IonGrid>
      </IonContent>
    </IonPage>
  );
};

export default GridPage;
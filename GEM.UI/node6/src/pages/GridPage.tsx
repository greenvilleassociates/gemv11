import React, { useEffect, useState } from 'react';
import { IonPage, IonHeader, IonToolbar, IonTitle, IonContent, IonList, IonItem, IonLabel, IonCard, IonCardContent } from '@ionic/react';

const GridPage: React.FC = () => {
    const nodeData = {
        databaseNodes: ["10.144.0.100", "10.144.1.100", "10.144.2.100", "10.144.3.100", "10.144.4.100"],
        webServerNodes: ["10.144.0.152", "10.144.1.151", "10.144.2.151", "10.144.3.151", "10.144.4.151"]
    };

    const [bestServer, setBestServer] = useState<string>("");
    const [nextBestServer, setNextBestServer] = useState<string>("");

    const getLatency = (ip: string): number => {
        return Math.floor(Math.random() * 100); // Simulated latency
    };

    const findBestServers = () => {
        let latencies = nodeData.webServerNodes.map(ip => ({ ip, latency: getLatency(ip) }));
        latencies.sort((a, b) => a.latency - b.latency);

        setBestServer(`${latencies[0].ip} (Latency: ${latencies[0].latency}ms)`);
        setNextBestServer(`${latencies[1].ip} (Latency: ${latencies[1].latency}ms)`);
    };

    useEffect(() => {
        findBestServers();
    }, []);

    return (
        <IonPage>
            <IonHeader>
                <IonToolbar>
                    <IonTitle>Web Server Selection</IonTitle>
                </IonToolbar>
            </IonHeader>
            <IonContent className="ion-padding">
                <IonList>
                    <IonItem>
                        <IonLabel><strong>Database Nodes</strong></IonLabel>
                    </IonItem>
                    {nodeData.databaseNodes.map(node => (
                        <IonItem key={node}>
                            <IonLabel>{node}</IonLabel>
                        </IonItem>
                    ))}
                </IonList>

                <IonList>
                    <IonItem>
                        <IonLabel><strong>Web Server Nodes</strong></IonLabel>
                    </IonItem>
                    {nodeData.webServerNodes.map(node => (
                        <IonItem key={node}>
                            <IonLabel>{node}</IonLabel>
                        </IonItem>
                    ))}
                </IonList>

                <IonCard className="diag-box">
                    <IonCardContent>
                        <IonItem color="success">
                            <IonLabel><strong>Best Web Server:</strong> {bestServer}</IonLabel>
                        </IonItem>
                        <IonItem color="secondary">
                            <IonLabel><strong>Second Best:</strong> {nextBestServer}</IonLabel>
                        </IonItem>
                    </IonCardContent>
                </IonCard>
            </IonContent>
        </IonPage>
    );
};

export default GridPage;

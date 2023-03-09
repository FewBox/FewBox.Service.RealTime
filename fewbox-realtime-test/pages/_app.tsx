import React, { useEffect } from 'react';
import * as signalR from "@microsoft/signalr";
//import '@fewbox/den-web/fewbox-den.min.css';
import '@fewbox/den-web/style/_boot-web.scss';
import { AppProps } from 'next/app';

export default function FewBoxApp({ Component, pageProps }: AppProps) {
    useEffect(() => {
        if (!window.connection) {
            const connection = new signalR.HubConnectionBuilder()
                .withUrl("https://localhost:5001/fewbox")
                .build();
            window.connection = connection;
            connection.start()
                .then(() => {
                    // Todo
                    connection.invoke('SendAll'/* Hub Method */, 'fewbox' /* Listner Method */, {"name":"xxx"})
                })
                .catch((err) => console.error(err));
        }
        return;
    }, []);
    return <Component {...pageProps} />;
}
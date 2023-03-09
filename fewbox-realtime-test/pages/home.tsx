import { Den } from '@fewbox/den-web';
import React, { useEffect, useState } from 'react';

export interface IHomePageProps {
}

const getArgValue = (arg: any) => {
    if (typeof (arg) == 'object') {
        return JSON.stringify(arg);
    }
    else if ((typeof (arg) == 'string')) {
        return arg;
    }
    else {
        return '';
    }
}

const HomePage = (props: IHomePageProps) => {
    const [realtimeMessage, setRealtimeMessage] = useState({ all: 'None' });
    useEffect(() => {
        if (window.connection) {
            window.connection.on("fewbox", (arg1: any, arg2: any, arg3: any, arg4: any, arg5: any, arg6: any, arg7: any, arg8: any, arg9: any, arg10: any) => {
                setRealtimeMessage({ ...realtimeMessage, all: `${getArgValue(arg1)}${getArgValue(arg2)}${getArgValue(arg3)}${getArgValue(arg4)}${getArgValue(arg5)}${getArgValue(arg6)}${getArgValue(arg7)}${getArgValue(arg8)}${getArgValue(arg9)}${getArgValue(arg10)}` })
            });
        }
    }, []);
    return (<Den.Components.Y padding='2em' cross={Den.Components.YCrossType.Center}>
        <Den.Components.VLabel size={Den.Components.SizeType.Large} caption={realtimeMessage.all} />
        <Den.Components.VForm handleSubmit={(data) => {
            window.connection.invoke('SendAll10', 'fewbox', data.arg1, data.arg2, data.arg3, data.arg4, data.arg5, data.arg6, data.arg7, data.arg8, data.arg9, data.arg10)
                .then(() => { console.log('Finished!'); });
        }}>
            <Den.Components.Y gap='1em' width='20em'>
                <Den.Components.VTextBox name='arg1' placeholder='Arg1' defaultValue='Arg1' />
                <Den.Components.VTextBox name='arg2' placeholder='Arg2' defaultValue='Arg2' />
                <Den.Components.VTextBox name='arg3' placeholder='Arg3' defaultValue='Arg3' />
                <Den.Components.VTextBox name='arg4' placeholder='Arg4' defaultValue='Arg4' />
                <Den.Components.VTextBox name='arg5' placeholder='Arg5' defaultValue='Arg5' />
                <Den.Components.VTextBox name='arg6' placeholder='Arg6' defaultValue='Arg6' />
                <Den.Components.VTextBox name='arg7' placeholder='Arg7' defaultValue='Arg7' />
                <Den.Components.VTextBox name='arg8' placeholder='Arg8' defaultValue='Arg8' />
                <Den.Components.VTextBox name='arg9' placeholder='Arg9' defaultValue='Arg9' />
                <Den.Components.VTextBox name='arg10' placeholder='Arg10' defaultValue='Arg10' />
                <Den.Components.VSubmit backgroundColor={Den.Components.ColorType.Primary} caption='Send All' />
            </Den.Components.Y>
        </Den.Components.VForm>
    </Den.Components.Y>);
}

export default HomePage;
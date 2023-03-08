import * as React from 'react';
import HomePage from './home';

export interface IRootProps {
}

class Root extends React.Component<IRootProps> {
  public render() {
    return (<HomePage />);
  }
}

export default Root;
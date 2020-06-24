import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { Info } from './components/Info';
import { Registration } from './components/Registration';
import { Auth } from './components/Auth';
import { Resourses } from './components/Resourses';
import { test } from './components/test';

import './custom.css'

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Layout>
            <Route exact path='/' component={Home} />
            <Route path='/registration' component={Registration} />
            <Route path='/auth' component={Auth} />
            <Route exact path='/info' component={Info} />
            <Route path='/resourses' component={Resourses} />
            <Route path='/test' component={test} />
           

      </Layout>
    );
  }
}

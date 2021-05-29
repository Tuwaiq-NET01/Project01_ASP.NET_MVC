import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import Navbar from './components/NavBar';
import { FetchData } from './components/FetchData';
import Store from './components/Store';
import Details from './components/Details';
import Cards from './components/Cards';
import { Counter } from './components/Counter';
import { Container, Card, Col } from 'react-bootstrap'


import './custom.css'

export default class App extends Component {
  static displayName = App.name;

  render() {
    return (
      <>
          <Navbar />
        <Route path='/stores' component={Store} />
        <Route path='/details/:id' component={Details} />
        <div className="App">
          {/* <Layout> */}
          <header className="App-header" >
            <Container>
              {/* <Route exact path='/' component={Home} /> */}
              <Route exact path='/' component={Cards} />
              <Route path='/counter' component={Counter} />
              <Route path='/fetch-data' component={FetchData} />
              <Route path='/cards' component={Cards} />
            </Container>

          </header>
          {/* </Layout> */}
        </div>
      </>
    );
  }
}

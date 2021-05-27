import React from 'react'
import { BrowserRouter as Router, Switch, Route } from 'react-router-dom'
import NavBar from './components/NavBar'
import Footer from './components/Footer'
import StoreScreen from './screens/StoreScreen'
import CustomersScreen from './screens/CustomersScreen'
import OrdersScreen from './screens/OrdersScreen'
import { createMuiTheme, ThemeProvider } from '@material-ui/core/styles'
import Particles from 'react-particles-js'

const theme = createMuiTheme({
  palette: {
    primary: {
      main: '#00695f',
    },
    secondary: {
      main: '#482880',
    },
  },
})

export default function App() {
  return (
    <ThemeProvider theme={theme}>
      <Router>
        <NavBar />
        <Particles
          id="app-background"
          params={{
            particles: {
              number: {
                value: 50,
              },
              size: {
                value: 3,
              },
            },
            interactivity: {
              events: {
                onhover: {
                  enable: true,
                  mode: 'repulse',
                },
              },
            },
          }}
        />
        <Switch>
          <Route path="/orders" component={OrdersScreen} />
          <Route path="/customers" component={CustomersScreen} />
          <Route path="/" component={StoreScreen} exact />
        </Switch>
        <Footer />
      </Router>
    </ThemeProvider>
  )
}

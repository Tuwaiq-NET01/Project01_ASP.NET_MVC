import React, { useEffect, useState } from 'react'
import { makeStyles } from '@material-ui/core/styles'
import Container from '@material-ui/core/Container'
import Paper from '@material-ui/core/Paper'
import Typography from '@material-ui/core/Typography'
import Grid from '@material-ui/core/Grid'
import IconButton from '@material-ui/core/IconButton'
import List from '@material-ui/core/List'
import ListItem from '@material-ui/core/ListItem'
import ListItemText from '@material-ui/core/ListItemText'
import ListItemAvatar from '@material-ui/core/ListItemAvatar'
import SettingsIcon from '@material-ui/icons/Settings'
import AccountBoxIcon from '@material-ui/icons/AccountBox'
import axios from 'axios'

const CUSTOMERS_API_URL =
  'https://tuwaiqstoreapi.azurewebsites.net/api/customers'

const useStyles = makeStyles((theme) => ({
  paper: {
    marginTop: theme.spacing(5),
    marginBottom: theme.spacing(8),
    padding: theme.spacing(10),
    display: 'flex',
    flexDirection: 'column',
    alignItems: 'center',
    bcustomerColor: '#4096A6',
    bcustomerRadius: theme.spacing(2),
  },
  divider: {
    bcustomerBottom: 'solid',
    bcustomerWidth: '1px',
    color: '#00695f',
    padding: '0.5rem',
    margin: 'auto',
    width: '1.5rem',
  },
  typography: {
    fontFamily: 'Orbitron',
  },
}))

const CustomersScreen = () => {
  const classes = useStyles()
  const [customers, setCustomers] = useState([])

  useEffect(() => {
    //FETCH all customers from the database
    axios
      .get(CUSTOMERS_API_URL)
      .then(function (response) {
        const customersArray = []

        response.data.forEach((customer) => {
          customersArray.push({
            id: customer.id,
            firstName: customer.firstName,
            lastName: customer.lastName,
            address: customer.address,
            email: customer.email,
            phone: customer.phone,
          })
        })

        setCustomers(customersArray)
      })
      .catch(function (error) {
        console.log(error)
      })
  }, [])

  return (
    <Container component="main" maxWidth="md">
      <Paper elevation={20} className={classes.paper}>
        <Typography className={classes.typography} component="h2" variant="h2">
          Customers
        </Typography>
        <div className={classes.divider} />
        <Grid container spacing={2}>
          <Grid item xs={12}>
            <List>
              {customers.map((customer, i) => {
                return (
                  <ListItem key={i}>
                    <ListItemAvatar
                      style={{ color: '#00695f', marginRight: 50 }}
                    >
                      <AccountBoxIcon style={{ width: 64, height: 64 }} />
                    </ListItemAvatar>
                    <ListItemText
                      style={{ color: '#00695f' }}
                      primary={customer.firstName + ' ' + customer.lastName}
                      secondary={customer.phone}
                    />
                    <ListItemText
                      style={{ color: '#00695f' }}
                      primary={customer.address}
                      secondary={customer.email}
                    />
                    <IconButton style={{ color: '#121212' }}>
                      <SettingsIcon />
                    </IconButton>
                  </ListItem>
                )
              })}
            </List>
          </Grid>
        </Grid>
      </Paper>
    </Container>
  )
}

export default CustomersScreen

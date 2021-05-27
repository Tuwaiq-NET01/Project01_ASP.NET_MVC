import React, { useEffect, useState } from 'react'
import { makeStyles } from '@material-ui/core/styles'
import Container from '@material-ui/core/Container'
import Paper from '@material-ui/core/Paper'
import Avatar from '@material-ui/core/Avatar'
import Typography from '@material-ui/core/Typography'
import ShoppingCartIcon from '@material-ui/icons/ShoppingCart'
import Grid from '@material-ui/core/Grid'
import IconButton from '@material-ui/core/IconButton'
import List from '@material-ui/core/List'
import ListItem from '@material-ui/core/ListItem'
import ListItemText from '@material-ui/core/ListItemText'
import ListItemAvatar from '@material-ui/core/ListItemAvatar'
import axios from 'axios'

const PRODUCTS_API_URL = 'https://tuwaiqstoreapi.azurewebsites.net/api/products'

const useStyles = makeStyles((theme) => ({
  paper: {
    marginTop: theme.spacing(5),
    marginBottom: theme.spacing(8),
    padding: theme.spacing(10),
    display: 'flex',
    flexDirection: 'column',
    alignItems: 'center',
    borderColor: '#4096A6',
    borderRadius: theme.spacing(2),
  },
  divider: {
    borderBottom: 'solid',
    borderWidth: '1px',
    color: '#00695f',
    padding: '0.5rem',
    margin: 'auto',
    width: '1.5rem',
  },
  typography: {
    fontFamily: 'Orbitron',
  },
}))

const StoreScreen = () => {
  const classes = useStyles()
  const [products, setProducts] = useState([])

  useEffect(() => {
    //FETCH all products from the database
    axios
      .get(PRODUCTS_API_URL)
      .then(function (response) {
        const productsArray = []

        response.data.forEach((product) => {
          productsArray.push({
            id: product.id,
            name: product.name,
            price: product.price,
            image: product.image,
          })
        })

        setProducts(productsArray)
      })
      .catch(function (error) {
        console.log(error)
      })
  }, [])

  return (
    <Container component="main" maxWidth="md">
      <Paper elevation={20} className={classes.paper}>
        <Typography className={classes.typography} component="h2" variant="h2">
          Products
        </Typography>
        <div className={classes.divider} />
        <Grid container spacing={2}>
          <Grid item xs={12}>
            <List>
              {products.map((product, i) => {
                return (
                  <ListItem key={i}>
                    <ListItemAvatar style={{ marginRight: 50 }}>
                      <Avatar
                        style={{ width: 84, height: 84 }}
                        src={product.image}
                      />
                    </ListItemAvatar>
                    <ListItemText
                      style={{ color: '#00695f' }}
                      primary={product.name}
                      secondary={'SAR ' + product.price}
                    />
                    <IconButton style={{ color: '#00695f' }}>
                      <ShoppingCartIcon />
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

export default StoreScreen

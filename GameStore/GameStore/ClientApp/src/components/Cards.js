import React, { useState, useEffect } from 'react'
import {Container, Card, Col } from 'react-bootstrap'
import axios from "axios"
import Details from './Details';
import { useHistory } from "react-router-dom";

const Cards = () => {
    const [gameData, setGameData] = useState(() => null)
    let history = useHistory();


    useEffect(() => {
        const url = `https://localhost:5001/Products`

        axios({
            method: 'GET',
            url: url
        }).then(response => {
            console.log(response.data);
            setGameData(prevGameData => prevGameData=(response.data))
        })
    }, [])

    let all = gameData == null? <h1>kkk</h1> : gameData.map((game) => {
        return (
            // <Col onClick={console.log("jdjdj")} lg={3}>
                <Card id='card' onClick={()=>  history.push(`/Details/${game.id}`)} style={{ width: '20rem' }}>
                    <Card.Body className='cardBody' onClick={console.log("jdjdj")}>
                        <Card.Title>{game.name}</Card.Title>
                        <Card.Img className='imgCard' variant="top" src={game.img} />
                        <div className='pointer' onClick={console.log("jdjdj")}>
                            {/* {props.filter === 'fav' ? <VscChromeClose /> : (isFave &&
                        (props.filter === 'all' || props.filter === 'fav' || props.filter === 'search')) ?
                        <MdFavorite color='red' />
                        : <MdFavorite />} */}
                        </div>
                    </Card.Body>
                </Card>
            // </Col>
    )})
    return (
        <>
        {all}
        </>
    );
}

export default Cards;
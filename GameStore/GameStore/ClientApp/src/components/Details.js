import React, { useState, useEffect } from 'react';
import axios from "axios"
import { Carousel, Image, Row, Col, Container } from 'react-bootstrap'
import 'bootstrap/dist/css/bootstrap.css'
import Navbar from './NavBar';
// import './Detailscss.css';

const Details = (props) => {
    const [gameData, setGameData] = useState(() => null)
    var myall = document.querySelector(".App");
    var myobj = document.querySelector(".App-header");


    useEffect(() => {
        const url = `https://localhost:5001/Products`

        axios({
            method: 'GET',
            url: url
        }).then(response => {
            console.log(response.data);
            setGameData(prevGameData => prevGameData = (response.data[props.match.params.id - 1]))
            console.log(gameData, "pppp");
        })
    }, [])
    const styles = {
        width: window.innerWidth
    };
    let allimg = gameData == null ? console.log("jkkk")
        :
        <div style={styles}>
            <Carousel>
                {gameData.screenShots[0] === undefined ? console.log('No img') :
                    <Carousel.Item id='slideImg' interval={1000}>
                        <img id='slideImg'
                            src={gameData.screenShots[0]}
                            height="250"
                            alt=""
                        />
                    </Carousel.Item>
                }
                {gameData.screenShots[1] === undefined ? console.log('No img') :
                    <Carousel.Item id='slideImg' interval={1000}>
                        <img id='slideImg'
                            src={gameData.screenShots[1]}
                            height="250"
                            alt=""
                        />
                    </Carousel.Item>
                }
                {gameData.screenShots[2] === undefined ? console.log('No img') :
                    <Carousel.Item id='slideImg' interval={1000}>
                        <img id='slideImg'
                            src={gameData.screenShots[2]}
                            height="250"
                            alt=""
                        />
                    </Carousel.Item>
                }
                {gameData.screenShots[3] === undefined ? console.log('No img') :
                    <Carousel.Item id='slideImg' interval={1000}>
                        <img id='slideImg'
                            src={gameData.screenShots[3]}
                            height="250"
                            alt=""
                        />
                    </Carousel.Item>
                }
                {gameData.screenShots[4] === undefined ? console.log('No img') :
                    <Carousel.Item id='slideImg' interval={1000}>
                        <img id='slideImg'
                            src={gameData.screenShots[4]}
                            height="250"
                            alt=""
                        />
                    </Carousel.Item>
                }
                {gameData.screenShots[5] === undefined ? console.log('No img') :
                    <Carousel.Item id='slideImg' interval={1000}>
                        <img id='slideImg'
                            src={gameData.screenShots[5]}
                            height="250"
                            alt=""
                        />
                    </Carousel.Item>
                }
                {gameData.screenShots[6] === undefined ? console.log('No img') :
                    <Carousel.Item id='slideImg' interval={1000}>
                        <img id='slideImg'
                            src={gameData.screenShots[6]}
                            height="250"
                            alt=""
                        />
                    </Carousel.Item>
                }
            </Carousel>
        </div>

    myobj == null ? console.log("555") : myobj.style.display = "none";
    console.log(myobj);

    var myobj1 = document.getElementById("desc")
    myobj1 == null ? console.log("555") : myobj1.style.color = gameData.color;;
    
    return (


        <div id="det">
            {allimg}
            <h1 id="gametitle">{gameData==null?console.log(""):gameData.name}</h1>
            {/* <div id="desc">jj</div> */}
            <Image id="imgthumbnail" src={gameData==null?console.log(""):gameData.img} thumbnail />
            
        </div>
    );
}

export default Details;
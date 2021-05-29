import React from 'react'
import { Container, Row, Col } from 'react-bootstrap'
import { useHistory } from "react-router-dom";

const Store = () => {
    const styles = {
        marginLeft: 0,
        float:"left",
        width: "25%",
        height:window.innerHeight
    };
    let history = useHistory();
    return (
        <>
            <div className="store"><img style={styles} onClick={() => window.location.replace("https://store.steampowered.com/")} src="https://steamuserimages-a.akamaihd.net/ugc/955210159014192230/7948B5285F0F9FCADCC5912BCE008101D7E6E5D7/"></img></div>

            <div className="store"><img style={styles} onClick={() => window.location.replace("https://www.xbox.com/ar-SA/")} src="https://store-images.s-microsoft.com/image/apps.38595.13798539581762600.215d02f1-0142-4972-88fb-175001d957e3.4cc7b353-559a-4bf8-8bad-8c88c6957b08"></img></div>

            <div className="store"><img style={styles} onClick={() => window.location.replace("https://www.playstation.com/en-us/")} src="https://i.pinimg.com/originals/85/28/b7/8528b7c5bde3f026628f6465934d8736.jpg"></img></div>

            <div className="store"><img style={styles} onClick={() => window.location.replace("https://www.nintendo.com/")} src="https://i.pinimg.com/originals/6a/80/a5/6a80a575d34a25cc30e5ff5674567e5e.gif"></img></div>

        </>
    );
}

export default Store;
import React from 'react';
import { Nav } from 'react-bootstrap'
import 'bootstrap/dist/css/bootstrap.css'
import { InputGroup, Input, Icon } from 'rsuite';
import 'rsuite/dist/styles/rsuite-default.css';
import { useHistory } from "react-router-dom";
const Navbar = (props) => {
    const styles = {
        width: 300,
        marginTop: 10,
        marginBottom: 5
    };
    let history = useHistory();

    let clc = () => {
        var x = document.querySelector(".App-header");
        if (x.style.display === "none") {
            x.style.removeProperty('display');
        }
        history.push('/')
    }
    return (
        <Nav id='fixed-top' fill>
            <Nav.Item id='navtabs'>
                <Nav.Link onClick={() => clc()} >All games</Nav.Link>
            </Nav.Item>
            {/* <InputGroup inside style={styles}>
                <Input placeholder="Game name" onChange={(event) => props.handleSearchClick(event)} />
                <InputGroup.Button>
                    <Icon icon="search" />
                </InputGroup.Button>
            </InputGroup> */}
            <Nav.Item id='navtabs'>
                <Nav.Link onClick={() => history.push('/Stores')}>Stores</Nav.Link>
            </Nav.Item>
        </Nav>
    );
}
export default Navbar;
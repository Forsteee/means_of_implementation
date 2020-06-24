import React, { Component } from 'react';
import { Collapse, Container, Navbar, NavbarBrand, NavbarToggler, NavItem, NavLink } from 'reactstrap';
import { Link } from 'react-router-dom';
import './NavMenu.css';
import logo from '../images/logo.png';

export class NavMenu extends Component {
  static displayName = NavMenu.name;

  constructor (props) {
    super(props);

    this.toggleNavbar = this.toggleNavbar.bind(this);
    this.state = {
      collapsed: true
    };
  }

  toggleNavbar () {
    this.setState({
      collapsed: !this.state.collapsed
    });
  }

  render () {
    return (
      <header>
            <Navbar className="navbar navbar-expand-lg navbar-light bg-light">
                <NavbarBrand tag={Link} to="/">
                    <img className="header-logo" src={logo} alt="logo" />
                </NavbarBrand>
                <form className="form-group">
                    <div className="input-group">
                        <input className="form-control mr-sm-2" type="text" placeholder="Search" />
                        <div className="input-group-append">
                            <button className="btn btn-primary my-2 my-sm-0" type="submit" id="buttons">Поиск</button>
                        </div>
                    </div>
                    <div className="btn-group" role="group" aria-label="Basic example" id="m">
                        <NavLink tag={Link} to="/info">
                            <button type="button" className="btn btn-primary mr-sm-4" id="buttons">О библиотеке</button>
                        </NavLink>
                        <NavLink tag={Link} to="/resourses">
                            <button type="button" className="btn btn-primary mr-sm-4" id="buttons">Ресурсы</button>
                        </NavLink>
                        <NavLink tag={Link} to="/">
                            <button type="button" className="btn btn-primary mr-sm-4" id="buttons">Мои книги</button>
                        </NavLink>
                    </div>
                </form>
                <div className="btn-group" role="group" aria-label="Basic example" id="m1">
                    <NavLink tag={Link} to="/registration">
                        <button type="button" className="btn">Регистрация</button>
                    </NavLink>
                    <NavLink tag={Link} to="/auth">
                        <button type="button" className="btn">Авторизация</button>
                    </NavLink>
                </div>
        </Navbar>
      </header>
    );
  }
}

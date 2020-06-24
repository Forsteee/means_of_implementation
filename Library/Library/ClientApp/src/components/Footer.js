import React, { Component } from 'react';
import './Footer.css';

export class Footer extends Component {
    render() {
        return (
            <footer>
                <p className="text text-center">© 2020 Государственное автономное учреждение культуры<b>"Библиотека"</b></p>
                <p className="text text-center"><b>Контактный телефон:</b> +78005553535</p>
            </footer>
        );
    }
}
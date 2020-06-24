import React, { Component } from 'react';
import { Button } from 'reactstrap';

export class Auth extends Component {
    render() {
        return (
            <div>
                <p className="title">Бронь</p>
                <hr />
                <form action="" className="form">
                    <div className="form-field">
                        <p>Номер документа:</p>
                        <input type="text" />
                    </div>
                    <div className="form-field">
                        <p>Название документа:</p>
                        <input type="text" />
                    </div>
                    <div className="form-field">
                        <p>Дата выдачи:</p>
                        <input type="text" />
                    </div>
                    <Button color="primary">Забронировать</Button>
                </form>
            </div>
        );
    }
}

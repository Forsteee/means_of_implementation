import React, { Component } from 'react';
import { Button } from 'reactstrap';

export class Auth extends Component {
    render() {
        return (
            <div>
                <p className="title">�����</p>
                <hr />
                <form action="" className="form">
                    <div className="form-field">
                        <p>����� ���������:</p>
                        <input type="text" />
                    </div>
                    <div className="form-field">
                        <p>�������� ���������:</p>
                        <input type="text" />
                    </div>
                    <div className="form-field">
                        <p>���� ������:</p>
                        <input type="text" />
                    </div>
                    <Button color="primary">�������������</Button>
                </form>
            </div>
        );
    }
}

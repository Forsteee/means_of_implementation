import React, { Component } from 'react';
const fakeCarts = [
    {
        id:"1",
        name: 'Nordway Combi',
    }
];

export class test extends Component {

    constructor(props) {
        super(props);
        this.state = {
            carts: fakeCarts,
        };
    }
    componentDidMount() {
        this.getCarts();
    }
    async getCarts() {
        const response = await fetch('catalog');
        const data = await response.json();
        this.setState({ carts: data });
    }

    renderCarts = () => {
        const {
            carts,
        } = this.state;

        return carts.map((cart) => {
                return (
                    <div className="catalog-cart col-2">
                            <p className="catalog-cart-title">{cart.id}</p>
                            <p className="catalog-cart-amount">{cart.name}</p>
                       
                    </div>
                )           
        })
    };

    render() {
        return (
           
                <div className="catalog-carts col-12 row">
                    {this.renderCarts()}
                </div>

        );
    }


   /* constructor(props) {
        super(props);
        this.state = { forecasts: [], loading: true };
    }
    static renderForecastsTable(forecasts) {
        return (
            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>Date</th>
                        
                    </tr>
                </thead>
                <tbody>
                    {forecasts.map(forecast =>
                        <tr >
                            <td>{forecast.Date}</td>
                            
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }
    render() {
        let contents = test.renderForecastsTable(this.state.forecasts);

        return (
            <div>
                <h1 id="tabelLabel" >Weather forecast</h1>
                <p>This component demonstrates fetching data from the server.</p>
                {contents}
            </div>
        );
    }*/



}
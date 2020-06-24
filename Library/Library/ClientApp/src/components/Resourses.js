import React, { Component } from 'react';
import { Pagination, PaginationItem, NavLink, PaginationLink } from 'reactstrap';
import './Resourses.css'

const fakeBook = [
    {
        id: "1",
        name: '',
        description: "Подключение к бд....",
        yPublishing:"",
        img:""
    }
];

export class Resourses extends Component {
    static displayName = 'Ресурсы';
    constructor(props) {
        super(props);
        this.state = {
            books: fakeBook,
            countPagination: 1,
            countView: 4,
        };
    }
    componentDidMount() {
        this.getBooks();
    }
    async getBooks() {
        const response = await fetch('resoursess');
        const data = await response.json();
        this.setState({ books: data });
    }

    renderBooks = () => {
        const {
            books,          
            countPagination,
            countView,
        } = this.state;

        const minValue = countView * (countPagination - 1);//с какой карточки начинается стр
        const maxValue = countView * countPagination;

        return books.map((book, i) => {
            if (minValue <= i && i < maxValue)
            { 
                return (
                    <div className="media m-4">                
                        <img className="d-flex mr-3" src={`${book.img}`} alt="" />
                        <div className="media-body">
                            <h5 className="mt-0">{book.name}</h5>
                            <p>Год публикации: {book.yPublishing}</p>
                            <p>{book.description}</p>
                            <button type="button" class="btn btn-primary">Заказать</button>
                        </div>
                    </div>
                )
            }
        })
    };
    onClickPagination = (str) => {
        const {
            books,
            countView
        } = this.state;

        const maxStep = Math.ceil(books.length / countView);
        if (str !== 0 && str <= maxStep) {
            this.setState({ countPagination: str })
        }
    }
    testPagination = (props) => {
        return (
            <Pagination size="sm" aria-label="Page navigation example">
                <PaginationItem>
                    <PaginationLink previous onClick={() => this.onClickPagination(this.state.countPagination - 1)} />
                </PaginationItem>
                <PaginationItem>
                    <PaginationLink onClick={() => this.onClickPagination(1)}>
                        1
          </PaginationLink>
                </PaginationItem>
                <PaginationItem>
                    <PaginationLink onClick={() => this.onClickPagination(2)}>
                        2
          </PaginationLink>
                </PaginationItem>
                <PaginationItem>
                    <PaginationLink onClick={() => this.onClickPagination(3)}>
                        3
          </PaginationLink>
                </PaginationItem>
                <PaginationItem>
                    <PaginationLink next onClick={() => this.onClickPagination(this.state.countPagination + 1)} />
                </PaginationItem>
            </Pagination>
        );
    };
    render() {
        return (

            <div className="container">
             
                <div className="row">
                    <div className="col mt-3" id="news">
                            {this.renderBooks()}
                    </div>   
                </div>
                {this.testPagination()}
            </div>

          
                        
                    




           

        );
    }
}

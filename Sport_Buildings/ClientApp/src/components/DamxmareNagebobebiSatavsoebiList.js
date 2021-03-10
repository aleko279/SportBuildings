import React, { Component } from 'react';
import authService from './api-authorization/AuthorizeService'
import Card from 'react-bootstrap/Card';
import CardGroup from 'react-bootstrap/CardGroup';
import CollapseDiv from '../components/CollapseDiv'
import DamxmareModal from './DamxmareModal';
export class DamxmareNagebobebiSatavsoebiList extends Component {

    constructor(props) {
        super(props);
        //  this.state = { forecasts: [], loading: true };
        this.state = {
            forecasts: [],
            pager: {},
            pageOfItems: [],
            loading: true,
            forType: 'all',
            newSearch: false,
            type: this.props.type,
            data: {},
            currentUser: null,
            isAdmin: false,
            showLocation: false,
            show: false,
            showDamObj : false
        };
        this.chanegPageSession = this.chanegPageSession.bind(this);
    }
    chanegPageSession(el) {
        var page = el.currentTarget.attributes['page'].value;
        var p = (page == null ? 1 : page);
        sessionStorage.setItem("page", p);
        this.populateSportBuildingsData();
    }
    showModal = e => {
        this.setState({
            show: !this.state.show
        });
    };
    showDamObjModal = e => {
        this.setState({
            showDamObj: !this.state.showDamObj
        });
    };
    componentDidMount() {
        sessionStorage.setItem('page', 1);
        this.populateSportBuildingsData();
    }
    async populateSportBuildingsData() {
        const token = await authService.getAccessToken();
        var page = parseInt(sessionStorage.getItem('page')) || 1;
        page = (page === 0 ? 1 : page);
        var type;
        const params = new URLSearchParams(window.location.search);
        const id = parseInt(params.get('id'));
        type = `api/SportBuilding/GetDamxmareNagebobebiSatavsoebiList?objID=${id}&count=10&page=${page}`

        if (page !== this.state.pager.currentPage) {
            const response = await fetch(type, {
                method: "POST",
                //  body: JSON.stringify(res),
                headers: {
                    'Accept': 'application/json',
                    'Content-Type': 'application/json'
                },

            });
            const data = await response.json();
            this.setState({ pager: data, pageOfItems: data.daxmareNagebobebiData, loading: false });
        }

        //const response = await fetch('weatherforecast', {
        //    headers: !token ? {} : { 'Authorization': `Bearer ${token}` }
        //});
        // const data = await response.json();
        // this.setState({ forecasts: data, loading: false });
    }
    static renderForecastsTable(forecasts, ttt) {

        return (

            <div>

                <table className='table table-striped' aria-labelledby="tabelLabel">
                    <thead>
                        <tr>
                            <th>ID</th>
                            <th>დასახელება</th>
                            <th>დანიშნულება</th>
                        </tr>
                    </thead>
                    <tbody>

                        {forecasts.map(forecast =>
                            <tr key={forecast.objectid}>

                                <button
                                    className="toggle-button"
                                    id="centered-toggle-button"
                                    onClick={e => {
                                        ttt.showDamObjModal(e);
                                    }}
                                >
                                    {" "}
                                    show Modalo{" "}
                                </button>

                                <td>{forecast.objectid}</td>
                                <td>{forecast.dasaxeleba}</td>

                                <td>{forecast.danishnuleba}</td>
                            </tr>
                        )}

                    </tbody>
                </table>
            </div>
        );
    }
    render() {
        const { pager, pageOfItems } = this.state;
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : DamxmareNagebobebiSatavsoebiList.renderForecastsTable(pageOfItems, this);

        return (


            <div>


                <div className="App">
                    <button
                        className="toggle-button"
                        id="centered-toggle-button"
                        onClick={e => {
                            this.showModal(e);
                        }}
                    >
                        {" "}
                        show Modal{" "}
                    </button>

                    <CollapseDiv onClose={this.showModal} show={this.state.show}>

                        <h3 id="tabelLabel" >დამხმარე ნაგებობები</h3>
                        {contents}

                        {
                            pager.pages != null && pager.pages.length > 0 && this.props.type === this.state.type ?
                                <div className="TotalText">
                                    {`${pager.currentPage * 10 - 9}-${pager.currentPage * 10 > pager.iTotalRecords ? pager.iTotalRecords : pager.currentPage * 10} ობიექტი `}
                                    <span style={{ fontFamily: 'HelveticaBold' }}>{pager.iTotalRecords.toLocaleString()} - დან</span>
                                </div>
                                : <></>
                        }

                        <div className="pb-0 pt-3 automargin">
                            {pager.pages != null && pager.pages.length > 0 && this.props.type === this.state.type ?
                                <ul className="pagination mainPagination">
                                    <li className={`page-item first-item ${pager.currentPage === 1 ? 'disabled' : ''}`}>
                                        <div page={1} onClick={this.chanegPageSession.bind(this)} className="page-link">
                                            <svg className="bi bi-chevron-double-left" width="1em" height="1em" viewBox="0 0 16 16" fill="currentColor" xmlns="http://www.w3.org/2000/svg">
                                                <path fillRule="evenodd" d="M8.354 1.646a.5.5 0 010 .708L2.707 8l5.647 5.646a.5.5 0 01-.708.708l-6-6a.5.5 0 010-.708l6-6a.5.5 0 01.708 0z" clipRule="evenodd" />
                                                <path fillRule="evenodd" d="M12.354 1.646a.5.5 0 010 .708L6.707 8l5.647 5.646a.5.5 0 01-.708.708l-6-6a.5.5 0 010-.708l6-6a.5.5 0 01.708 0z" clipRule="evenodd" />
                                            </svg>
                                        </div>
                                    </li>
                                    <li className={`page-item previous-item ${pager.currentPage === 1 ? 'disabled' : ''}`}>
                                        <div page={pager.currentPage - 1} onClick={this.chanegPageSession.bind(this)} className="page-link">
                                            <svg className="bi bi-chevron-left" width="1em" height="1em" viewBox="0 0 16 16" fill="currentColor" xmlns="http://www.w3.org/2000/svg">
                                                <path fillRule="evenodd" d="M11.354 1.646a.5.5 0 010 .708L5.707 8l5.647 5.646a.5.5 0 01-.708.708l-6-6a.5.5 0 010-.708l6-6a.5.5 0 01.708 0z" clipRule="evenodd" />
                                            </svg>
                                        </div>
                                    </li>
                                    {pager.pages.map(page =>
                                        <li key={page} className={`page-item number-item ${pager.currentPage === page ? 'active' : ''}`}>
                                            <div className="page-link" page={page} onClick={this.chanegPageSession.bind(this)}>{page}</div>
                                        </li>
                                    )}
                                    <li className={`page-item next-item ${pager.currentPage === pager.totalPages ? 'disabled' : ''}`}>
                                        <div page={pager.currentPage + 1} onClick={this.chanegPageSession.bind(this)} className="page-link">
                                            <svg className="bi bi-chevron-right" width="1em" height="1em" viewBox="0 0 16 16" fill="currentColor" xmlns="http://www.w3.org/2000/svg">
                                                <path fillRule="evenodd" d="M4.646 1.646a.5.5 0 01.708 0l6 6a.5.5 0 010 .708l-6 6a.5.5 0 01-.708-.708L10.293 8 4.646 2.354a.5.5 0 010-.708z" clipRule="evenodd" />
                                            </svg>
                                        </div>
                                    </li>
                                    <li className={`page-item last-item ${pager.currentPage === pager.totalPages ? 'disabled' : ''}`}>
                                        <div page={pager.totalPages} onClick={this.chanegPageSession.bind(this)} className="page-link">
                                            <svg className="bi bi-chevron-double-right" width="1em" height="1em" viewBox="0 0 16 16" fill="currentColor" xmlns="http://www.w3.org/2000/svg">
                                                <path fillRule="evenodd" d="M3.646 1.646a.5.5 0 01.708 0l6 6a.5.5 0 010 .708l-6 6a.5.5 0 01-.708-.708L9.293 8 3.646 2.354a.5.5 0 010-.708z" clipRule="evenodd" />
                                                <path fillRule="evenodd" d="M7.646 1.646a.5.5 0 01.708 0l6 6a.5.5 0 010 .708l-6 6a.5.5 0 01-.708-.708L13.293 8 7.646 2.354a.5.5 0 010-.708z" clipRule="evenodd" />
                                            </svg>
                                        </div>
                                    </li>
                                </ul>
                                : <></>
                            }
                        </div>

                    </CollapseDiv>

                    <DamxmareModal onClose={this.showDamObjModal} show={this.state.showDamObj}>

                    </DamxmareModal>
                </div>


            </div>
        );

    }
}
export default DamxmareNagebobebiSatavsoebiList;
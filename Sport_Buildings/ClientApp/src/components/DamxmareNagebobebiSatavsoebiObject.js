import React, { Component } from 'react';
import authService from './api-authorization/AuthorizeService'
import Card from 'react-bootstrap/Card';
import CardGroup from 'react-bootstrap/CardGroup';
import DamxmareModal from '../components/DamxmareModal'
export class DamxmareNagebobebiSatavsoebiObject extends Component {

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
            showDamObj: false
        };
        this.chanegPageSession = this.chanegPageSession.bind(this);
    }
    chanegPageSession(el) {
        var page = el.currentTarget.attributes['page'].value;
        var p = (page == null ? 1 : page);
        sessionStorage.setItem("page", p);
        this.populateSportBuildingsData();
    }
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
            : DamxmareNagebobebiSatavsoebiObject.renderForecastsTable(pageOfItems, this);

        return (


            <div>


                <div className="App">

                    <DamxmareModal onClose={this.showDamObjModal} show={this.state.showDamObj}>

                        <h3 id="tabelLabel" >დამხმარე ნაგებობა</h3>
                        {contents}

                    </DamxmareModal>
                </div>


            </div>
        );

    }
}
export default DamxmareNagebobebiSatavsoebiObject;
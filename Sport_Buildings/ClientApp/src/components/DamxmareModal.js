import React, { Component } from 'react';
import { Formik, Field, Form, ErrorMessage } from 'formik';
import { authenticationService } from '../_services/';
import * as Yup from 'yup';
import { useEffect } from 'react';
import { Row, Col } from 'react-bootstrap';
import PropTypes from "prop-types";

export class DamxmareModal extends React.Component {

    constructor(props) {
        super(props);
        this.state = {
            currentUser: null,
            error: '',
            planets: [],
            sportTypes: [],
            show: false
            //currentCount: 0
            //  objectID: null
            //      sportBuilding: {},
        };
        //this.incrementCounter = this.incrementCounter.bind(this);
    }
    componentDidMount() {
        this.loadPage();
    }
    async loadPage() {
        const params = new URLSearchParams(window.location.search);
        if (params.get('id')) {
            const id = parseInt(params.get('id'));
            if (id !== null) {
                authenticationService.getDamxmareNagebobebiSatavsoebiObject(id).then(
                    object => {
                        this.setState({ object: object })
                    },
                    error => {
                        this.setState({ error: error })
                    }
                );
            }
        }
    }

    onClose = e => {
        this.props.onClose && this.props.onClose(e);
    };
    render() {
        if (!this.props.show) {
            return null;
        }
        //return (
        //    <div className="DamxmareNagebobebiSatavsoebimodal" id="DamxmareNagebobebiSatavsoebimodalmodal">
        //        <div>
        //            {this.props.children}
        //        </div>
        //    </div>
        //);
        return (
            <div className="DamxmareModal" id="DamxmareModal">
                <h2>Modal Window</h2>
                <div className="content">{this.props.children}</div>
                <div className="actions">
                    <button className="toggle-button" onClick={this.onClose}>
                        close
                        </button>
                </div>
            </div>
        );
    }
}
DamxmareModal.propTypes = {
    onClose: PropTypes.func.isRequired,
    show: PropTypes.bool.isRequired
};

export default DamxmareModal;
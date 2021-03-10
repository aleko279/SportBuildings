import React, { Component } from 'react';
import { Formik, Field, Form, ErrorMessage } from 'formik';
import { authenticationService } from '../_services/';
import * as Yup from 'yup';
import { useEffect } from 'react';
import { Row, Col } from 'react-bootstrap';
import PropTypes from "prop-types";

export class CollapseDiv extends React.Component {

    constructor(props) {
        super(props);
        this.state = {
            sportTypes: [],
            show: false
        };

    }
    onClose = e => {
        this.props.onClose && this.props.onClose(e);
    };

    render() {
        if (!this.props.show) {
            return null;
        }
        return (
            <div className="CollapseDiv" id="CollapseDiv">
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
CollapseDiv.propTypes = {
    onClose: PropTypes.func.isRequired,
    show: PropTypes.bool.isRequired
};

export default CollapseDiv;
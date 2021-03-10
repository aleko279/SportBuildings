import React, { Component } from 'react';
import { Formik, Field, Form, ErrorMessage } from 'formik';
import { authenticationService } from '../_services/';
import * as Yup from 'yup';
import { useEffect } from 'react';
import { Row, Col } from 'react-bootstrap';
import { Route, withRouter } from 'react-router-dom';
import './SportBuildingObject.css'
import CollapseDiv from '../components/CollapseDiv'
import DamxmareNagebobebiSatavsoebiList from '../components/DamxmareNagebobebiSatavsoebiList'
import { Button, Collapse } from 'react-bootstrap'
const Schema = Yup.object().shape({
    BuildingName: Yup.string().required('შეიყვანეთ სახელწოდება'),
    Raioni: Yup.string().required('შეიყვანეთ მუნიციპალიტეტი'),
    Sofeli: Yup.string().required('შეიყვანეთ დასახლებული პუნქტი'),
    Regioni: Yup.string().required('შეიყვანეთ დასახლებული პუნქტი'),
    //Qucha: Yup.string().required('შეიყვანეთ დასახლებული პუნქტი')

});


function handleChange(e) {
    console.log(e.target.value);
    console.log(document.getElementsByName("Regioni"));
    document.getElementsByName("Regioni").value = "test";
}
export class SportBuildingObject extends Component {
    static displayName = SportBuildingObject.name;

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
    showModal = e => {
        this.setState({
            show: !this.state.show
            //  damxmareNagebobaModalID: URLSearchParams(window.location.search).get('id');
        });
    };
    componentDidMount() {
        this.loadPage();
    }
    async loadPage() {
        //const params = new URLSearchParams(window.location.search);
        //const id = parseInt(params.get('id'));
        //if (id !== null) {
        //    var type = `api/SportBuilding/getSportBuildingObject?id=${id}`;


        //    const response = await fetch(type);

        //    const data = await response.json();
        //    this.setState({ sportBuilding: data, loading: false, objectID: data.id });

        //}
        let initialPlanets = [];
        fetch('api/SportBuilding/getLkpRegion')
            .then(response => {
                return response.json();
            }).then(data => {
                initialPlanets = data;
                console.log(initialPlanets);
                this.setState({
                    planets: initialPlanets,
                });
            });

        let initialSportTypes = [];
        fetch('api/SportBuilding/getLkpSportType')
            .then(response => {
                return response.json();
            }).then(data => {
                initialSportTypes = data;
                console.log(initialSportTypes);
                this.setState({
                    sportTypes: initialSportTypes,
                });
            });

        const params = new URLSearchParams(window.location.search);
        if (params.get('id')) {
            const id = parseInt(params.get('id'));
            if (id !== null) {
                authenticationService.getObject(id).then(
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




    render() {

        let planets = this.state.planets;
        let optionItems = planets.map((planet) =>
            <option key={planet.name} value={planet.objectid}>{planet.name} </option>
        );
        let sportTypes = this.state.sportTypes;
        let sportTypeItems = sportTypes.map((sportType) =>
            <option key={sportType.name} value={sportType.objectid}>{sportType.name} </option>
        );
        //const sportB = this.state.sportBuilding;
        const arg = {
            isFullyOpened: true || false, // `true` only when Collapse reached final height
            isFullyClosed: true || false, // `true` only when Collapse is fully closed and height is zero
            isOpened: true || false, // `true` if Collapse has any non-zero height
            containerHeight: 123, // current pixel height of Collapse container (changes until reaches `contentHeight`)
            contentHeight: 123 // determined height of supplied Content
        }
        return (
            <div style={{ backgroundColor: 'white', width: '100%', height: '100%' }}>
                <Formik
                    initialValues={{
                        Objectid: 0,
                        BuildingName: '',
                        SportType: '',
                        Regioni: '',
                        Raioni: '',
                        Sofeli: '',
                        Qucha: '',
                        Saxli: '',
                        TelNumber: '',
                        WebSite: '',
                        PostalCode: '',
                        Email: '',
                        DaarsebisWeli: '',
                        DawesebulebisXelmdzgvaneli: '',
                        OrganizaciisIuridiuliSaxelwodeba: '',
                        OrganizaciisIuridiuliStatusi: '',
                        GoogleMapCoordinates: '',
                        OrganizaciisXelmdzgvaneli: '',
                        OrganizaciisXelmdzgvanelisStatusi: '',
                        InformaciaAdaptirebulobis: '',
                        EqspSesvlisTariRi: '',
                        Sabalanso_Rirebuleba: '',
                        ParcelArea: '',
                        SaqKodi: '',
                        gengegma: ''
                    }}
                    validationSchema={Schema}
                    onSubmit={({ id, BuildingName, SportType, Regioni, Raioni, Sofeli, Qucha, WebSite, PostalCode, Email, DaarsebisWeli, DawesebulebisXelmdzgvaneli, OrganizaciisIuridiuliSaxelwodeba, OrganizaciisIuridiuliStatusi, GoogleMapCoordinates, OrganizaciisXelmdzgvaneli, OrganizaciisXelmdzgvanelisStatusi, InformaciaAdaptirebulobis, Saxli, TelNumber, EqspSesvlisTariRi, Sabalanso_Rirebuleba, ParcelArea, SaqKodi, gengegma },
                        { setStatus, setSubmitting }) => {
                        setStatus();

                        authenticationService.addobject({ id, BuildingName, SportType, Regioni, Raioni, Sofeli, Qucha, WebSite, PostalCode, Email, DaarsebisWeli, DawesebulebisXelmdzgvaneli, OrganizaciisIuridiuliSaxelwodeba, OrganizaciisIuridiuliStatusi, GoogleMapCoordinates, OrganizaciisXelmdzgvaneli, OrganizaciisXelmdzgvanelisStatusi, InformaciaAdaptirebulobis, Saxli, TelNumber, EqspSesvlisTariRi, Sabalanso_Rirebuleba, ParcelArea, SaqKodi, gengegma })
                            .then(
                                user => {
                                    const { from } = this.props.location.state || { from: { pathname: "/FetchData" } };
                                    this.props.history.push(from);
                                },
                                error => {
                                    setSubmitting(false);
                                    setStatus(error);
                                }
                            );

                    }}>
                    {({ errors, status, touched, isSubmitting, setFieldValue }) => {
                        useEffect(() => {
                            const params = new URLSearchParams(window.location.search);
                            if (params.get('id')) {
                                const id = parseInt(params.get('id'));
                                if (id !== null) {
                                    authenticationService.getObject(id).then(
                                        object => {
                                            setFieldValue('Objectid', object.objectid)
                                            //  setFieldValue('images', object.images)
                                            setFieldValue('SportType', object.sportType)
                                            setFieldValue('BuildingName', object.buildingName)
                                            setFieldValue('Regioni', object.regioni)
                                            setFieldValue('Raioni', object.raioni)
                                            setFieldValue('Sofeli', object.sofeli)
                                            setFieldValue('Qucha', object.qucha)
                                            setFieldValue('Saxli', object.Saxli)
                                            setFieldValue('TelNumber', object.TelNumber)
                                            setFieldValue('WebSite', object.webSite)
                                            setFieldValue('PostalCode', object.postalCode)
                                            setFieldValue('Email', object.email)
                                            setFieldValue('DaarsebisWeli', object.DaarsebisWeli)
                                            setFieldValue('DawesebulebisXelmdzgvaneli', object.DawesebulebisXelmdzgvaneli)
                                            setFieldValue('OrganizaciisIuridiuliSaxelwodeba', object.OrganizaciisIuridiuliSaxelwodeba)
                                            setFieldValue('OrganizaciisIuridiuliStatusi', object.OrganizaciisIuridiuliStatusi)
                                            setFieldValue('GoogleMapCoordinates', object.GoogleMapCoordinates)
                                            setFieldValue('OrganizaciisXelmdzgvaneli', object.OrganizaciisXelmdzgvaneli)
                                            setFieldValue('OrganizaciisXelmdzgvanelisStatusi', object.OrganizaciisXelmdzgvanelisStatusi)
                                            setFieldValue('InformaciaAdaptirebulobis', object.InformaciaAdaptirebulobis)
                                            setFieldValue('EqspSesvlisTariRi', object.EqspSesvlisTariRi)
                                            setFieldValue('Sabalanso_Rirebuleba', object.Sabalanso_Rirebuleba)
                                            setFieldValue('ParcelArea', object.ParcelArea)
                                            setFieldValue('SaqKodi', object.SaqKodi)
                                            setFieldValue('gengegma', object.gengegma)


                                            //if (setPoint != null) {
                                            //    setPoint(object.x, object.y)
                                            //}
                                            //else {
                                            //    this.setState(
                                            //        { coordinatebi: { x: object.x, y: object.y } })
                                            //}
                                        }
                                    );
                                }
                            }


                        }, []);

                        return (

                            <Form>
                                {status &&
                                    <div className={'alert alert-danger'}>{status}</div>
                                }
                                <h1>სპორტული ნაგებობა</h1>
                                <div className="borderPassportDiv">
                                    <h5 className="pasportHeader">პასპორტი</h5>
                                    <Row className="form-group">
                                        <Col style={{ marginTop: '1rem' }} md={3}>
                                            <Field autoComplete="off" name="id" type="hidden" />

                                            <Field autoComplete="off" name="BuildingName" type="text" className={'form-control contactText' + (errors.BuildingName && touched.BuildingName ? ' is-invalid' : '')} placeholder="სახელწოდება*" />
                                            <ErrorMessage name="BuildingName" component="div" className="invalid-feedback" />
                                        </Col>
                                        <Col style={{ marginTop: '1rem' }} md={3}>
                                            <Field type="date" autoComplete="off" name="DaarsebisWeli" className={'form-control contactText' + (errors.DaarsebisWeli && touched.DaarsebisWeli ? ' is-invalid' : '')} placeholder="დაარსების წელი" />
                                            <ErrorMessage name="DaarsebisWeli" component="div" className="invalid-feedback" />
                                        </Col>
                                        <Col style={{ marginTop: '1rem' }} md={3}>
                                            <Field autoComplete="off" name="DawesebulebisXelmdzgvaneli" type="text" className={'form-control contactText' + (errors.DawesebulebisXelmdzgvaneli && touched.DawesebulebisXelmdzgvaneli ? ' is-invalid' : '')} placeholder="დაწესებულების ხელმძღვანელი" />
                                            <ErrorMessage name="DawesebulebisXelmdzgvaneli" component="div" className="invalid-feedback" />
                                        </Col>
                                    </Row>
                                    <Row>
                                        <Col style={{ marginTop: '1rem' }} md={3}>
                                            <Field autoComplete="off" name="OrganizaciisIuridiuliSaxelwodeba" type="text" className={'form-control contactText' + (errors.OrganizaciisIuridiuliSaxelwodeba && touched.OrganizaciisIuridiuliSaxelwodeba ? ' is-invalid' : '')} placeholder="ორგანიზაციის იურიდიული სახელწოდება" />
                                            <ErrorMessage name="OrganizaciisIuridiuliSaxelwodeba" component="div" className="invalid-feedback" />
                                        </Col>
                                        <Col style={{ marginTop: '1rem' }} md={3}>
                                            <Field autoComplete="off" name="OrganizaciisIuridiuliStatusi" type="text" className={'form-control contactText' + (errors.OrganizaciisIuridiuliStatusi && touched.OrganizaciisIuridiuliStatusi ? ' is-invalid' : '')} placeholder="ორგანიზაციის იურიდიული სტატუსი" />
                                            <ErrorMessage name="OrganizaciisIuridiuliStatusi" component="div" className="invalid-feedback" />
                                        </Col>
                                        <Col style={{ marginTop: '1rem' }} md={3}>
                                            <Field autoComplete="off" name="GoogleMapCoordinates" type="text" className={'form-control contactText' + (errors.GoogleMapCoordinates && touched.GoogleMapCoordinates ? ' is-invalid' : '')} placeholder="გუგლის კოორდინატები" />
                                            <ErrorMessage name="GoogleMapCoordinates" component="div" className="invalid-feedback" />
                                        </Col>
                                    </Row>
                                    <Row>
                                        <Col style={{ marginTop: '1rem' }} md={3}>
                                            <Field autoComplete="off" name="OrganizaciisXelmdzgvaneli" type="text" className={'form-control contactText' + (errors.OrganizaciisXelmdzgvaneli && touched.OrganizaciisXelmdzgvaneli ? ' is-invalid' : '')} placeholder="ორგანიზაციის ხელმძღვანელის სახელი, გვარი" />
                                            <ErrorMessage name="OrganizaciisXelmdzgvaneli" component="div" className="invalid-feedback" />
                                        </Col>
                                        <Col style={{ marginTop: '1rem' }} md={3}>
                                            <Field autoComplete="off" name="OrganizaciisXelmdzgvanelisStatusi" type="text" className={'form-control contactText' + (errors.OrganizaciisXelmdzgvanelisStatusi && touched.OrganizaciisXelmdzgvanelisStatusi ? ' is-invalid' : '')} placeholder="ორგანიზაციის ხელმძღვანელის სტატუსი" />
                                            <ErrorMessage name="OrganizaciisXelmdzgvanelisStatusi" component="div" className="invalid-feedback" />
                                        </Col>
                                        <Col style={{ marginTop: '1rem' }} md={3}>
                                            <Field autoComplete="off" name="InformaciaAdaptirebulobis" type="text" className={'form-control contactText' + (errors.InformaciaAdaptirebulobis && touched.InformaciaAdaptirebulobis ? ' is-invalid' : '')} placeholder="ინფორმაცია ადაპტირებულობის" />
                                            <ErrorMessage name="InformaciaAdaptirebulobis" component="div" className="invalid-feedback" />
                                        </Col>

                                    </Row>
                                </div>
                                <div className="borderSaertoMonacemebiDiv">

                                    <h5 className="SaertoMonacemebiHeader">საერთო მონაცემები</h5>
                                    <Row>
                                        <Col style={{ marginTop: '1rem' }} md={3}>
                                            <select className={'form-control contactText' + (errors.Regioni && touched.Regioni ? ' is-invalid' : '')} onChange={(e) => this.setState({ Regioni: e.target.value })} >
                                                {optionItems}
                                            </select>
                                        </Col>
                                        <Col style={{ marginTop: '1rem' }} md={3}>
                                            <Field autoComplete="off" name="Raioni" type="text" className={'form-control contactText' + (errors.Raioni && touched.Raioni ? ' is-invalid' : '')} placeholder="მუნიციპალიტეტი*" />
                                            <ErrorMessage name="Raioni" component="div" className="invalid-feedback" />
                                        </Col>
                                        <Col style={{ marginTop: '1rem' }} md={3}>
                                            <Field autoComplete="off" name="Sofeli" type="text" className={'form-control contactText' + (errors.Sofeli && touched.Sofeli ? ' is-invalid' : '')} placeholder="დასახლებული პუნქტი*" />
                                            <ErrorMessage name="Sofeli" component="div" className="invalid-feedback" />
                                        </Col>
                                    </Row>
                                    <Row className="form-group">

                                        <Col style={{ marginTop: '1rem' }} md={3}>
                                            <Field autoComplete="off" name="Qucha" type="text" className={'form-control contactText' + (errors.Qucha && touched.Qucha ? ' is-invalid' : '')} placeholder="ქუჩა" />
                                            <ErrorMessage name="Qucha" component="div" className="invalid-feedback" />
                                        </Col>
                                        <Col style={{ marginTop: '1rem' }} md={3}>
                                            <Field autoComplete="off" name="Saxli" type="text" className={'form-control contactText' + (errors.Saxli && touched.Saxli ? ' is-invalid' : '')} placeholder="სახლი" />
                                            <ErrorMessage name="Saxli" component="div" className="invalid-feedback" />
                                        </Col>
                                        <Col style={{ marginTop: '1rem' }} md={3}>
                                            <Field autoComplete="off" name="PostalCode" type="text" className={'form-control contactText' + (errors.PostalCode && touched.PostalCode ? ' is-invalid' : '')} placeholder="საფოსტო ინდექსი" />
                                            <ErrorMessage name="PostalCode" component="div" className="invalid-feedback" />
                                        </Col>
                                    </Row>

                                    <Row className="form-group">
                                        <Col style={{ marginTop: '1rem' }} md={3}>
                                            <Field autoComplete="off" name="WebSite" type="text" className={'form-control contactText' + (errors.WebSite && touched.WebSite ? ' is-invalid' : '')} placeholder="ვებსაიტი" />
                                            <ErrorMessage name="WebSite" component="div" className="invalid-feedback" />
                                        </Col>
                                        <Col style={{ marginTop: '1rem' }} md={3}>
                                            <Field autoComplete="off" name="Email" type="text" className={'form-control contactText' + (errors.Email && touched.Email ? ' is-invalid' : '')} placeholder="იმეილი" />
                                            <ErrorMessage name="Email" component="div" className="invalid-feedback" />
                                        </Col>
                                        <Col style={{ marginTop: '1rem' }} md={3}>
                                            <Field autoComplete="off" name="TelNumber" type="text" className={'form-control contactText' + (errors.TelNumber && touched.TelNumber ? ' is-invalid' : '')} placeholder="ტელეფონის ნომერი" />
                                            <ErrorMessage name="TelNumber" component="div" className="invalid-feedback" />
                                        </Col>
                                    </Row>

                                    <Row>
                                        <Col style={{ marginTop: '1rem' }} md={3}>
                                            <Field type="date" autoComplete="off" name="EqspSesvlisTariRi" className={'form-control contactText' + (errors.EqspSesvlisTariRi && touched.EqspSesvlisTariRi ? ' is-invalid' : '')} placeholder="ექსპლუატაციაში შესვლის თარიღი" />
                                            <ErrorMessage name="EqspSesvlisTariRi" component="div" className="invalid-feedback" />
                                        </Col>
                                        <Col style={{ marginTop: '1rem' }} md={3}>
                                            <Field autoComplete="off" name="Sabalanso_Rirebuleba" type="text" className={'form-control contactText' + (errors.Sabalanso_Rirebuleba && touched.Sabalanso_Rirebuleba ? ' is-invalid' : '')} placeholder="საბალანსო ღირებულება" />
                                            <ErrorMessage name="Sabalanso_Rirebuleba" component="div" className="invalid-feedback" />
                                        </Col>
                                        <Col style={{ marginTop: '1rem' }} md={3}>
                                            <Field autoComplete="off" name="ParcelArea" type="text" className={'form-control contactText' + (errors.ParcelArea && touched.ParcelArea ? ' is-invalid' : '')} placeholder="მიწის ნაკვეთი ჰა ან მ2" />
                                            <ErrorMessage name="ParcelArea" component="div" className="invalid-feedback" />
                                        </Col>

                                    </Row>

                                    <Row>
                                        <Col style={{ marginTop: '1rem' }} md={3}>
                                            <Field autoComplete="off" name="SaqKodi" type="text" className={'form-control contactText' + (errors.SaqKodi && touched.SaqKodi ? ' is-invalid' : '')} placeholder="საკადასტრო კოდი" />
                                            <ErrorMessage name="SaqKodi" component="div" className="invalid-feedback" />
                                        </Col>
                                        <Col style={{ marginTop: '1rem' }} md={3}>
                                            <Field autoComplete="off" name="SaqKodi" type="text" className={'form-control contactText' + (errors.gengegma && touched.gengegma ? ' is-invalid' : '')} placeholder="გენგეგმა" />
                                            <ErrorMessage name="gengegma" component="div" className="invalid-feedback" />
                                        </Col>
                                        <Col style={{ marginTop: '1rem' }} md={3}>
                                            <select className={'form-control contactText' + (errors.SportType && touched.SportType ? ' is-invalid' : '')} onChange={(e) => this.setState({ SportType: e.target.value })} >
                                                {sportTypeItems}
                                            </select>
                                        </Col>
                                    </Row>




                                    <Row className="form-group">
                                        <Col style={{ marginTop: '1rem' }} >
                                            <button type="submit" className="MainButton" disabled={isSubmitting}>გაგზავნა</button>
                                            {isSubmitting &&
                                                <img alt="" src="data:image/gif;base64,R0lGODlhEAAQAPIAAP///wAAAMLCwkJCQgAAAGJiYoKCgpKSkiH/C05FVFNDQVBFMi4wAwEAAAAh/hpDcmVhdGVkIHdpdGggYWpheGxvYWQuaW5mbwAh+QQJCgAAACwAAAAAEAAQAAADMwi63P4wyklrE2MIOggZnAdOmGYJRbExwroUmcG2LmDEwnHQLVsYOd2mBzkYDAdKa+dIAAAh+QQJCgAAACwAAAAAEAAQAAADNAi63P5OjCEgG4QMu7DmikRxQlFUYDEZIGBMRVsaqHwctXXf7WEYB4Ag1xjihkMZsiUkKhIAIfkECQoAAAAsAAAAABAAEAAAAzYIujIjK8pByJDMlFYvBoVjHA70GU7xSUJhmKtwHPAKzLO9HMaoKwJZ7Rf8AYPDDzKpZBqfvwQAIfkECQoAAAAsAAAAABAAEAAAAzMIumIlK8oyhpHsnFZfhYumCYUhDAQxRIdhHBGqRoKw0R8DYlJd8z0fMDgsGo/IpHI5TAAAIfkECQoAAAAsAAAAABAAEAAAAzIIunInK0rnZBTwGPNMgQwmdsNgXGJUlIWEuR5oWUIpz8pAEAMe6TwfwyYsGo/IpFKSAAAh+QQJCgAAACwAAAAAEAAQAAADMwi6IMKQORfjdOe82p4wGccc4CEuQradylesojEMBgsUc2G7sDX3lQGBMLAJibufbSlKAAAh+QQJCgAAACwAAAAAEAAQAAADMgi63P7wCRHZnFVdmgHu2nFwlWCI3WGc3TSWhUFGxTAUkGCbtgENBMJAEJsxgMLWzpEAACH5BAkKAAAALAAAAAAQABAAAAMyCLrc/jDKSatlQtScKdceCAjDII7HcQ4EMTCpyrCuUBjCYRgHVtqlAiB1YhiCnlsRkAAAOwAAAAAAAAAAAA==" />
                                            }
                                        </Col>
                                    </Row>
                                </div>
                                {/*დამალული რეგიონი იდ*/}
                                <Col style={{ marginTop: '1rem' }} md={3}>
                                    <Field type="hidden" autoComplete="off" name="Regioni" value={this.state.Regioni} className={'form-control contactText' + (errors.Regioni && touched.Regioni ? ' is-invalid' : '')} placeholder="რეგიონი*" />
                                    <ErrorMessage name="Regioni" component="div" className="invalid-feedback" />
                                </Col>
                                {/*დამალული sport type იდ*/}
                                <Col style={{ marginTop: '1rem' }} md={3}>
                                    <Field type="hidden" autoComplete="off" name="SportType" value={this.state.SportType} className={'form-control contactText' + (errors.SportType && touched.SportType ? ' is-invalid' : '')} placeholder="სპორტის ტიპი*" />
                                    <ErrorMessage name="Regioni" component="div" className="invalid-feedback" />
                                </Col>

                                <DamxmareNagebobebiSatavsoebiList> </DamxmareNagebobebiSatavsoebiList>



                                <CollapseDiv onClose={this.showModal} show={this.state.show}>
                                    Lorem ipsum dolor sit amet, consectetur adipisicing elit. Nobis
                                    deserunt corrupti, ut fugit magni qui quasi nisi amet repellendus non
                                    fuga omnis a sed impedit explicabo accusantium nihil doloremque
                                    consequuntur.
                                    </CollapseDiv>

                                <br />
                                <br />
                                <br />
                                <br />


                                <button
                                    className="toggle-button"
                                    id="centered-toggle-button"
                                    onClick={e => {
                                        this.showModal(e);
                                    }}
                                >
                                    {" "}
                                    show Modalo{" "}
                                </button>


                            </Form>

                        );
                    }}

                </Formik>
            </div>
        );
    }
}
export default SportBuildingObject;
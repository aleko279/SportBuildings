import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { FetchData } from './components/FetchData';
import { Counter } from './components/Counter';
import AuthorizeRoute from './components/api-authorization/AuthorizeRoute';
import ApiAuthorizationRoutes from './components/api-authorization/ApiAuthorizationRoutes';
import { ApplicationPaths } from './components/api-authorization/ApiAuthorizationConstants';
import { SportBuildingObject } from './components/SportBuildingObject';
import { DamxmareModal } from './components/DamxmareModal';
import { CollapseDiv } from './components/CollapseDiv';
import { DamxmareNagebobebiSatavsoebiList } from './components/DamxmareNagebobebiSatavsoebiList';
import './custom.css'

export default class App extends Component {
    static displayName = App.name;

    render() {
        return (
            <Layout>
                <Route exact path='/' component={Home} />
                <Route path='/counter' component={Counter} />
                <Route exact path='/objects/SportBuilding/SportBuildingObject' component={SportBuildingObject} />
                <Route exact path='/objects/SportBuilding/DamxmareModal' component={DamxmareModal} />
                <Route exact path='/objects/SportBuilding/CollapseDiv' component={CollapseDiv} />
                <Route exact path='/objects/SportBuilding/DamxmareNagebobebiSatavsoebiList' component={DamxmareNagebobebiSatavsoebiList} />
                <AuthorizeRoute path='/fetch-data' component={FetchData} />
                <Route path={ApplicationPaths.ApiAuthorizationPrefix} component={ApiAuthorizationRoutes} />
            </Layout>
        );
    }
}

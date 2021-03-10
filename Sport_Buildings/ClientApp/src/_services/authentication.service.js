import { BehaviorSubject } from 'rxjs';

import { authHeader, handleResponse } from '../_helpers';

const currentUserSubject = new BehaviorSubject(JSON.parse(localStorage.getItem('currentUser')));

export const authenticationService = {
    login,
    logout,
    register,
    updateprofile,
    resetPassword,
    updatePassword,
    addobject,
    getObject,
    getDamxmareNagebobebiSatavsoebiObject,
    currentUser: currentUserSubject.asObservable(),
    get currentUserValue() { return currentUserSubject.value }
};

function login(email, password) {
    const requestOptions = {
        method: 'POST',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify({ email, password })
    };

    return fetch(`api/Users/Authenticate`, requestOptions)
        .then(handleResponse)
        .then(user => {
            // store user details and jwt token in local storage to keep user logged in between page refreshes
            localStorage.setItem('currentUser', JSON.stringify(user));
            currentUserSubject.next(user);

            return user;
        });

}

function logout() {
    // remove user from local storage to log user out
    localStorage.removeItem('currentUser');
    currentUserSubject.next(null);
}

function register(user) {

    var fmData = new FormData();
    fmData.append('citizenship', user.citizenship);
    fmData.append('firstName', user.firstName);
    fmData.append('lastName', user.lastName);
    fmData.append('username', user.username);
    fmData.append('personalNum', user.personalNum);
    fmData.append('password', user.password);
    fmData.append('passwordrepeat', user.passwordrepeat);
    fmData.append('photo', user.photo);

    const requestOptions = {
        method: 'POST',
        headers: {
            'Accept': 'application/json',
        },
        body: fmData
    };

    return fetch(`api/Users/Register`, requestOptions)
        .then(handleResponse)
        .then(message => {

            //localStorage.setItem('currentUser', JSON.stringify(user));
            //currentUserSubject.next(user);

            return message;
        });
}

function updateprofile(user) {

    var fmData = new FormData();
    fmData.append('password', user.password);
    fmData.append('passwordrepeat', user.passwordrepeat);
    fmData.append('photo', user.photo);
    fmData.append('photoChanged', user.photoChanged);

    const requestOptions = {
        method: 'POST',
        headers: authHeader(),        
        body: fmData
    };

    return fetch(`api/Users/UpdateUser`, requestOptions)
        .then(handleResponse)
        .then(result => {
            if (result.error === "") {
                alert('მონაცემები განახლებულია');
            }
            localStorage.setItem('currentUser', JSON.stringify(result.user));
            currentUserSubject.next(result.user);

            return result.error;
        });
}

function resetPassword(email) {
   
    const requestOptions = {
        method: 'POST',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(email)
    };

    return fetch(`api/Users/PasswordReset`, requestOptions)
        .then(handleResponse)
        .then(message => {
            return message;
        }).catch(function (message) {
            return "error:"+message;
        });
}

function updatePassword(email,code,data) {
    var fmData = new FormData();   
    fmData.append('password', data.password);
    fmData.append('passwordrepeat', data.passwordrepeat);
    
    const requestOptions = {
        method: 'POST',
        body: fmData
    };

    return fetch(`api/Users/UpdatePassword?email=${email}&code=${code}`, requestOptions)
        .then(handleResponse)
        .then(message => {
            alert('მონაცემები განახლებულია');
            return message;
        });
}

function addobject(object) {

    var fmData = new FormData();
    fmData.append('id', object.ObjectId);
    fmData.append('BuildingName', object.BuildingName);
    fmData.append('SportType', object.SportType);
    fmData.append('Regioni', object.Regioni);
    fmData.append('Raioni', object.Raioni);
    fmData.append('Sofeli', object.Sofeli);
    fmData.append('Qucha', object.Qucha);
  //  fmData.append('streetNum', object.streetNum);
   // fmData.append('description', object.description);
    //fmData.append('photos', object.photos.filter(photo => photo !== ""));

    //for (var i = 0; i < object.photos.length; i++) {
    //    if (object.photos[i] !== "") {
    //        fmData.append('photos', object.photos[i]);
    //    }
    //}

    //for ( i = 0; i < object.images.length; i++) {
    //    if (object.images[i] !== "") {
    //        fmData.append('images', object.images[i]);
    //    }
    //}
    //fmData.append('photo', object.photos[0]);
    //fmData.append('x', x);
    //fmData.append('y', y);

    const requestOptions = {
        method: 'POST',
        headers: authHeader(),
        body: fmData
    };

   
    //const requestOptions = { method: 'GET', headers: authHeader() };
    //const response = await fetch(type, requestOptions);

    return fetch(`api/SportBuilding/AddObject`, requestOptions)
        .then(handleResponse)
        .then(message => {
            return message;
        });
}

function getObject(id) {
    var type = `api/SportBuilding/getSportBuildingObject?id=${id}`;

    const requestOptions = {
        method: 'GET',
        headers: authHeader()
    };
    return fetch(type, requestOptions)
        .then(handleResponse)
        .then(object => {
            return object;
        });
} 
function getDamxmareNagebobebiSatavsoebiObject(id) {
    var type = `api/SportBuilding/getDamxmareNagebobebiObject?id=${id}`;

    const requestOptions = {
        method: 'GET',
        headers: authHeader()
    };
    return fetch(type, requestOptions)
        .then(handleResponse)
        .then(object => {
            return object;
        });
} 
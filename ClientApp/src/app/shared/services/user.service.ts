import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { env } from "process";
import { environment } from "src/environments/environment";
import { UserModel } from "../models/user.model";

@Injectable()
export class UserService {

    constructor(public http: HttpClient){}
    accessPointUrl: string = environment.webApi + 'Client';
    authUrl: string = environment.webApi + 'Auth';


    getAll() {
        return this.http.get(this.accessPointUrl + '/all');
    }

    register(user: UserModel) {
        return this.http.post(this.authUrl + '/register', user);
    }

    login(user: UserModel) {
        return this.http.post(this.authUrl + '/login', user);
    }

    getById(id: number) {
        return this.http.get(this.accessPointUrl + '/' + id);
    }

    update(book: UserModel) {
        return this.http.patch(this.accessPointUrl + '/update', book);
    }

    create(book: UserModel) {
        return this.http.post(this.accessPointUrl + '/create', book);
    }

    delete(id: number) {
        return this.http.delete(this.accessPointUrl + '/' + id);
    }
}
import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { environment } from "src/environments/environment";
import { AuthorModel } from "../models/book.model";

@Injectable()
export class AuthorService {

    constructor(public http: HttpClient){}
    accessPointUrl: string = environment.webApi + 'Author';

    authors: AuthorModel[] = [];

    getAll() {
        return this.http.get(this.accessPointUrl + '/all');
    }

    getById(id: number) {
        return this.http.get(this.accessPointUrl + '/' + id);
    }

    update(book: AuthorModel) {
        return this.http.patch(this.accessPointUrl + '/update', book);
    }

    create(book: AuthorModel) {
        return this.http.post(this.accessPointUrl + '/create', book);
    }

    delete(id: number) {
        return this.http.delete(this.accessPointUrl + '/' + id);
    }
}
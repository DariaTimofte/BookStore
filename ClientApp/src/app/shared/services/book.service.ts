import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { env } from "process";
import { environment } from "src/environments/environment";
import { BookModel } from "../models/book.model";
import { UserModel } from "../models/user.model";

@Injectable()
export class BookService {

    constructor(public http: HttpClient){}
    accessPointUrl: string = environment.webApi + 'Book';

    getAll() {
        return this.http.get(this.accessPointUrl + '/all');
    }

    getById(id: number) {
        return this.http.get(this.accessPointUrl + '/' + id);
    }

    update(book: BookModel) {
        return this.http.patch(this.accessPointUrl + '/update', book);
    }

    create(book: BookModel) {
        return this.http.post(this.accessPointUrl + '/create', book);
    }

    delete(id: number) {
        return this.http.delete(this.accessPointUrl + '/' + id);
    }
}
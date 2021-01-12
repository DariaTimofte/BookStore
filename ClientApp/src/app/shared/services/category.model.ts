import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { environment } from "src/environments/environment";
import { CategoryModel } from "../models/book.model";

@Injectable()
export class CategoryService {

    constructor(public http: HttpClient){}
    accessPointUrl: string = environment.webApi + 'Category';

    categories: CategoryModel[] = [];

    getAll() {
        return this.http.get(this.accessPointUrl + '/all');
    }

    getById(id: number) {
        return this.http.get(this.accessPointUrl + '/' + id);
    }

    update(book: CategoryModel) {
        return this.http.patch(this.accessPointUrl + '/update', book);
    }

    create(book: CategoryModel) {
        return this.http.post(this.accessPointUrl + '/create', book);
    }

    delete(id: number) {
        return this.http.delete(this.accessPointUrl + '/' + id);
    }
}
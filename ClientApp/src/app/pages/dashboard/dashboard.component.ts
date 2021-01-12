import { Component, OnInit } from "@angular/core";
import { FormBuilder, FormControl, FormGroup } from "@angular/forms";
import Chart from "chart.js";
import { AuthorModel, BookModel, CategoryModel } from "src/app/shared/models/book.model";
import { AuthorService } from "src/app/shared/services/author.service";
import { BookService } from "src/app/shared/services/book.service";
import { CategoryService } from "src/app/shared/services/category.model";

@Component({
  selector: "app-dashboard",
  templateUrl: "dashboard.component.html",
  styleUrls: ["./dashboard.component.css"],
  providers: [BookService, AuthorService, CategoryService],
})
export class DashboardComponent implements OnInit {
  books: BookModel[] = [];
  authors: AuthorModel[] = this.authorService.authors;
  categories: CategoryModel[] = this.categoryService.categories;

  bookForm: FormGroup;

  constructor(
    private bookService: BookService,
    private authorService: AuthorService,
    private categoryService: CategoryService,
    private fb: FormBuilder
  ) {}

  ngOnInit() {
    this.bookService.getAll().subscribe(
      (res: BookModel[]) => {
        this.books = res;
        console.log(this.books);
      },
      (err) => {
        console.log(err.error.message);
      }
    );

    this.bookForm = this.fb.group({
      'name': new FormControl(''),
      'author': new FormControl(''),
      'category': new FormControl(''), 
      'price': new FormControl(''), 
      'points': new FormControl(''), 
    });
  }

  // get name() { return this.bookForm.get('name'); }
  // get author() { return this.bookForm.get('author'); }
  // get category() { return this.bookForm.get('category'); }
  // get price() { return this.bookForm.get('price'); }
  // get points() { return this.bookForm.get('points'); }
}

import { HttpClient } from "@angular/common/http";
import { Component, OnInit } from "@angular/core";
import { AuthorModel, CategoryModel } from "./shared/models/book.model";
import { AuthorService } from "./shared/services/author.service";
import { CategoryService } from "./shared/services/category.model";

@Component({
  selector: "app-root",
  templateUrl: "./app.component.html",
  styleUrls: ["./app.component.scss"],
  providers: [AuthorService, CategoryService]
})
export class AppComponent implements OnInit {
  title = "book-store";

  constructor(
    private authorService: AuthorService,
    private categoryService: CategoryService
  ) {}

  ngOnInit() {
    this.authorService.getAll().subscribe(
      (author: AuthorModel[]) => {
        this.authorService.authors = author;
      },
      (err) => {
        console.log(err.error.message);
      }
    );

    this.categoryService.getAll().subscribe(
      (category: CategoryModel[]) => {
        this.categoryService.categories = category;
      },
      (err) => {
        console.log(err.error.message);
      }
    );
  }
}

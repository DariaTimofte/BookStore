import { Component, OnInit } from "@angular/core";
import { UserModel } from "src/app/shared/models/user.model";
import { UserService } from "src/app/shared/services/user.service";

@Component({
  selector: "app-user",
  templateUrl: "user.component.html",
  providers: [UserService]
})
export class UserComponent implements OnInit {
  users: UserModel[] = [];
  constructor( private userService: UserService) {}

  ngOnInit() {
    this.userService.getAll().subscribe( (res: UserModel[]) => {
      this.users = res;
    }, err => {
      console.log(err.error.message);
    })
  }
}

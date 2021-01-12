import { Injectable } from "@angular/core";
import { Router } from "@angular/router";
import { JwtHelperService } from "@auth0/angular-jwt";
import { UserModel } from "../models/user.model";

@Injectable()
export class AuthService {
  constructor(private router: Router, private jwtHelper: JwtHelperService) {}

  public getToken(): string {
    return localStorage.getItem("token");
  }

  get isLoggedIn() {
    const token = this.getToken();
    if (this.jwtHelper.isTokenExpired(token)) {
      return false;
    }
    return true;
  }

  login(user: UserModel) {
      if(user.email !== '') {
          localStorage.setItem("user", JSON.stringify(user));
      }
  }

  logout(){
    localStorage.setItem("user", '');
    localStorage.setItem('token', '');
    this.router.navigate(['/register']);
  }
}

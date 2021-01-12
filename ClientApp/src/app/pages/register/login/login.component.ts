import { Component, OnInit } from "@angular/core";
import {
  FormBuilder,
  FormControl,
  FormGroup,
  Validators,
} from "@angular/forms";
import { MatSnackBar } from "@angular/material/snack-bar";
import { Router } from "@angular/router";
import { AuthGuard } from "src/app/core/guards/auth.guard";
import { AuthResponse } from "src/app/shared/models/auth-response.model";
import { UserModel } from "src/app/shared/models/user.model";
import { AuthService } from "src/app/shared/services/auth.service";
import { UserService } from "src/app/shared/services/user.service";
import { emailValidator } from "src/app/shared/utils/app-validators";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"],
  providers: [UserService, AuthService],
})
export class LoginComponent implements OnInit {
  loginForm: FormGroup;

  constructor(
    public formBuilder: FormBuilder,
    public router: Router,
    public snackBar: MatSnackBar,
    private userService: UserService,
    private authService: AuthService
  ) {}

  ngOnInit() {
    this.loginForm = this.formBuilder.group({
      email: new FormControl(
        "",
        Validators.compose([Validators.required, emailValidator])
      ),
      password: new FormControl("", Validators.required),
    });
  }

  login() {
    let email = this.loginForm.get("email").value;
    let password = this.loginForm.get("password").value;

    let user = {
      email: email,
      password: password,
    } as UserModel;

    console.log(user);

    this.userService.login(user).subscribe(
      (res: AuthResponse) => {
        console.log(res);
        localStorage.setItem("token", res.token);

        this.snackBar.open("You logged in successfully!", "×", {
          panelClass: "success",
          verticalPosition: "top",
          duration: 5000,
        });

        this.authService.login(user);
        this.router.navigate(["/"]);
      },
      (err) => {
        console.log(err.error.message);
      }
    );
  }

  navigateToRegister() {
    this.router.navigate(["/register"]);
  }

  get email() {
    return this.loginForm.get("email");
  }

  get password() {
    return this.loginForm.get("password");
  }
}

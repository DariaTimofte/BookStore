import { Component } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthResponse } from 'src/app/shared/models/auth-response.model';
import { UserModel } from 'src/app/shared/models/user.model';
import { AuthService } from 'src/app/shared/services/auth.service';
import { UserService } from 'src/app/shared/services/user.service';
import { emailValidator, matchingPasswords, patternValidator } from 'src/app/shared/utils/app-validators';

@Component({
    selector: 'app-register',
    templateUrl: './register.component.html',
    styleUrls: ['./register.component.css'],
    providers: [UserService, AuthService]
})
export class RegisterComponent {

  registerForm: FormGroup;
  apiValues: string[] = [];

  constructor(
    public formBuilder: FormBuilder, 
    public router:Router, 
    private userService: UserService,
    private authService: AuthService
  ) {}

  ngOnInit() {
    this.registerForm = this.formBuilder.group({
      'email': new FormControl('', Validators.compose([Validators.required, emailValidator])),
      'password': new FormControl('', Validators.compose([
        //Pass is required
        Validators.required,
        //Check if pass has a number
        patternValidator(/\d/, { hasNumber: true }),
        //Check if pass has an uppercase letter
        patternValidator(/[A-Z]/, { hasCapitalCase: true }),
        //Check if pass has a lowercase letter
        patternValidator(/[a-z]/, { hasSmallCase: true }),
        //Check if pass has at least 6 characters
        Validators.minLength(6)
      ])),
      'confirmPassword': new FormControl('', Validators.required),
      'terms': new FormControl('', [(control) => {    
        return !control.value ? { 'required': true } : null;
      }])
    },
    {validator: matchingPasswords('password', 'confirmPassword')}
    );
  }

  register() {
    let email = this.registerForm.get('email').value;
    let password = this.registerForm.get('password').value;

    let user = {
      'email': email,
      'password': password
    } as UserModel;

    console.log(user);

    this.userService.register(user).subscribe((res: AuthResponse) => {
        console.log(res);
        localStorage.setItem("token", res.token);

        this.authService.login(user);
        this.router.navigate(["/user"]);
    }, err => {
        console.log(err.error.message);
    })
  }

  navigateToLogin() {
      this.router.navigate(['/login']);
  }

  get email() { return this.registerForm.get('email'); }
  get password() { return this.registerForm.get('password'); }
  get confirmPassword() { return this.registerForm.get('confirmPassword'); }
  get terms() { return this.registerForm.get('terms'); }
}
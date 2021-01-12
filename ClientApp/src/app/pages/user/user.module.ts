import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { ReactiveFormsModule } from '@angular/forms';
import { SharedModule } from 'src/app/shared/shared.module';
import { UserComponent } from './user.component';
import { UserRoutes } from './user-routing.module';
import { HighlightDirective } from 'src/app/shared/directives/highlight.directive';

@NgModule({
  imports: [
    CommonModule,
    RouterModule.forChild(UserRoutes),
    ReactiveFormsModule,
    SharedModule,
  ],
  declarations: [
    UserComponent,
    HighlightDirective
  ]
})
export class UserModule { }

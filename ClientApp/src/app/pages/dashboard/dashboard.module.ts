import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { ReactiveFormsModule } from '@angular/forms';
import { SharedModule } from 'src/app/shared/shared.module';
import { DashboardComponent } from './dashboard.component';
import { DashboardRoutes } from './dashboard-routing.module';
import { NamePipe } from 'src/app/shared/pipes/name.pipe';

@NgModule({
  imports: [
    CommonModule,
    RouterModule.forChild(DashboardRoutes),
    ReactiveFormsModule,
    SharedModule
  ],
  declarations: [
    DashboardComponent,
    NamePipe
  ]
})
export class DashboardModule { }

import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {FlexLayoutModule} from '@angular/flex-layout';
import { AdminLayoutComponent } from './admin-layout/admin-layout.component';
import { ComponentsModule } from '../components/components.module';
import { RegisterLayoutComponent } from './register-layout/register-layout.component';
import { LayoutsRoutingModule } from './layouts-routing.module';
import { AuthGuard } from '../core/guards/auth.guard';
import { AuthService } from '../shared/services/auth.service';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';

@NgModule({
  imports: [
    CommonModule,
    LayoutsRoutingModule,
    FlexLayoutModule,
    ComponentsModule,
    NgbModule
  ],
  exports: [],
  declarations: [
    AdminLayoutComponent,
    RegisterLayoutComponent,
  ], 
  providers: [
      AuthGuard, AuthService
    ]
})
export class LayoutModule { }

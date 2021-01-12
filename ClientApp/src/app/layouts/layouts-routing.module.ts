import { NgModule } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";
import { AuthGuard } from "../core/guards/auth.guard";
import { AdminLayoutComponent } from "./admin-layout/admin-layout.component";
import { RegisterLayoutComponent } from "./register-layout/register-layout.component";

const routes: Routes = [
  {
    path: "",
    component: AdminLayoutComponent,
    canActivate: [AuthGuard],
    children: [
      {
        path: "",
        loadChildren: "../pages/dashboard/dashboard.module#DashboardModule",
      },
      { path: "user", loadChildren: "../pages/user/user.module#UserModule" }
    ],
  },
  {
    path: "",
    component: RegisterLayoutComponent,
    children: [
      {
        path: "login",
        loadChildren: "../pages/register/login/login.module#LoginModule",
      },
      {
        path: "register",
        loadChildren: "../pages/register/register.module#RegisterModule",
      },
    ],
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class LayoutsRoutingModule {}

import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Auth } from '../auth/auth';
import { Login } from './login/login';
import { Registration } from './registration/registration';
import { AuthRoutingModule } from './auth-routing-module';
import { RouterModule } from '@angular/router';
import { SharedModule } from '../shared/shared-module';


@NgModule({
  declarations: [
    Auth,
    Login,
    Registration
  ],
  imports: [
    CommonModule,
    AuthRoutingModule,
    RouterModule,
    SharedModule
  ]
})
export class AuthModule { }

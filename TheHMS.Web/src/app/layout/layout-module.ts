import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Layout } from '../layout/layout';
import { Header } from './header/header';
import { Footer } from './footer/footer';
import { AppRoutingModule } from "../app-routing-module";



@NgModule({
  declarations: [
    Layout,
    Header,
    Footer
  ],
  imports: [
    CommonModule,
    AppRoutingModule
],

  exports: [Header,Footer] // ⬅ important

})
export class LayoutModule { }

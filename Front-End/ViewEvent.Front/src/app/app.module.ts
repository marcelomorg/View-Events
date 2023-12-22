import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations'
import { CollapseModule } from 'ngx-bootstrap/collapse' 

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './Pages/home/home.component';
import { NavComponent } from './Components/nav/nav.component';
import { FooterComponent } from './Components/footer/footer.component';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';

import { CarouselModule } from 'ngx-bootstrap/carousel';
import { ListComponent } from './Pages/list/list.component'
import { PaginationModule } from 'ngx-bootstrap/pagination';
import { RegisterComponent } from './Pages/register/register.component'
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    NavComponent,
    FooterComponent,
    ListComponent,
    RegisterComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FontAwesomeModule,
    CarouselModule.forRoot(),
    BrowserAnimationsModule,
    CollapseModule,
    PaginationModule.forRoot(),
    FormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

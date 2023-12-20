import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './Pages/home/home.component';
import { ListComponent } from './Pages/list/list.component';
import { RegisterComponent } from './Pages/register/register.component';

const routes: Routes = [
  {
    path: "",
    component: HomeComponent
  },
  {
    path: "list",
    component: ListComponent
  },
  {
    path: "register",
    component: RegisterComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

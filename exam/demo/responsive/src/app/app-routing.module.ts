import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {BootstrapComponent} from './bootstrap/bootstrap.component';
import {CssgridComponent} from './cssgrid/cssgrid.component';

const routes: Routes = [
  {path: '', component: BootstrapComponent},
  {path: 'bootstrap', component: BootstrapComponent},
  {path: 'cssgrid', component: CssgridComponent},
  {path: '**', component: BootstrapComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

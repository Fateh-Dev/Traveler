import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './home.component';
import { ApplicationLayoutComponent } from '@abp/ng.theme.basic';
import { TripsComponent } from './trips/trips.component';

const routes: Routes = [
  // { path: '', component: HomeComponent },
  // { path: 'trips', component: TripsComponent }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class HomeRoutingModule { }

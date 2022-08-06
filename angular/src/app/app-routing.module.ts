import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component';
import { DestinationsComponent } from './home/destinations/destinations.component';
import { GuidesComponent } from './home/guides/guides.component';
import { HelpComponent } from './home/help/help.component';
import { HomeComponent } from './home/home.component';
import { TripsComponent } from './home/trips/trips.component';
import { WishlistComponent } from './home/wishlist/wishlist.component';

const routes: Routes = [
  {
    path: 'auth',
    loadChildren: () => import('@abp/ng.account').then(m => m.AccountModule.forLazy()),

  },
  {
    path: '',
    component: AppComponent,
    children: [
      { path: '', component: HomeComponent },
      { path: 'trips', component: TripsComponent },
      { path: 'destinations', component: DestinationsComponent },
      { path: 'guides', component: GuidesComponent },
      { path: 'wishlist', component: WishlistComponent },
      { path: 'help', component: HelpComponent }, {
        path: 'account',
        loadChildren: () => import('@abp/ng.account').then(m => m.AccountModule.forLazy()),
      },
    ]
  },

  {
    path: 'identity',
    loadChildren: () => import('@abp/ng.identity').then(m => m.IdentityModule.forLazy()),
  },
  {
    path: 'tenant-management',
    loadChildren: () =>
      import('@abp/ng.tenant-management').then(m => m.TenantManagementModule.forLazy()),
  },
  {
    path: 'setting-management',
    loadChildren: () =>
      import('@abp/ng.setting-management').then(m => m.SettingManagementModule.forLazy()),
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes, { relativeLinkResolution: 'legacy' })],
  exports: [RouterModule],
})
export class AppRoutingModule { }

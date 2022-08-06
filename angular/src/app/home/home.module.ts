import { NgModule } from '@angular/core';
import { SharedModule } from '../shared/shared.module';
import { HomeRoutingModule } from './home-routing.module';
import { HomeComponent } from './home.component';
import { TripsComponent } from './trips/trips.component';
import { DestinationsComponent } from './destinations/destinations.component';
import { GuidesComponent } from './guides/guides.component';
import { HelpComponent } from './help/help.component';
import { WishlistComponent } from './wishlist/wishlist.component';
import { TripItemComponent } from './trips/trip-item/trip-item.component';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

@NgModule({
  declarations: [HomeComponent, TripsComponent, DestinationsComponent, GuidesComponent, HelpComponent, WishlistComponent, TripItemComponent],
  imports: [
    BrowserModule,
    BrowserAnimationsModule, SharedModule, HomeRoutingModule],
})
export class HomeModule { }

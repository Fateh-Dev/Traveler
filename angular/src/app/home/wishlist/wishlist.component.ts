import { Component, OnInit, ViewChild } from '@angular/core';
import { MatAccordion } from '@angular/material/expansion';
import { difficultyOptions, durationUnitOptions } from '@proxy';
import { TripService } from '@proxy/app-services';
import { TripMiniDto } from '@proxy/models';

@Component({
  selector: 'app-wishlist',
  templateUrl: './wishlist.component.html',
  styleUrls: ['./wishlist.component.scss']
})
export class WishlistComponent implements OnInit {

  @ViewChild(MatAccordion) accordion: MatAccordion;
  loading = false;
  items: TripMiniDto[] = [];
  constructor( 
    public tripService: TripService) {

  }
  ngOnInit() {
    this.loading = true
    this.tripService.getHomeList().subscribe(
      e => {
        this.items = e;
        this.loading = false
      })
  }
}

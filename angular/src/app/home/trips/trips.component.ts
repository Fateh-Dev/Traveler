import { Component, OnInit } from '@angular/core';
import { TripService } from '@proxy/app-services';
import { TripMiniDto } from '@proxy/models';

@Component({
  selector: 'app-trips',
  templateUrl: './trips.component.html',
  styleUrls: ['./trips.component.scss']
})
export class TripsComponent implements OnInit {

  loading = false;
  items: TripMiniDto[] = [];
  constructor(
    public tripService: TripService) { }

  ngOnInit(): void {
    this.loading = true
    this.tripService.getHomeList().subscribe(
      e => {
        this.items = e;
        this.loading = false
      })
  }

}

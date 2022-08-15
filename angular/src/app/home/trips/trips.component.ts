import { Component, OnInit } from '@angular/core';
import { difficultyOptions, durationUnitOptions } from '@proxy';
import { TripService } from '@proxy/app-services';
import { TripFilter, TripMiniDto } from '@proxy/models';

@Component({
  selector: 'app-trips',
  templateUrl: './trips.component.html',
  styleUrls: ['./trips.component.scss']
})
export class TripsComponent implements OnInit {
  filter: TripFilter = {
    maxResult: 12,
    pageSkip: 0
  }
  loading = false;
  items: TripMiniDto[] = [];
  constructor(
    public tripService: TripService) { }

  getEnumDiff(a) {
    return difficultyOptions.find(e => e.value == a).key
  }
  getEnumDuration(a) {
    return durationUnitOptions.find(e => e.value == a).key
  }
  ngOnInit(): void {
    this.loading = true
    this.tripService.getHomeList({ maxResult: 12, pageSkip: this.items.length }).subscribe(
      e => {
        this.items = e;
        this.loading = false
      })
  }

  loadMoreTrips() {
    this.filter.pageSkip = this.items.length;
    this.tripService.getHomeList(this.filter).subscribe(
      e => {
        this.items = this.items.concat(e)
      })
  }
  getTrips(rating) {
    this.loading = true
    this.filter.pageSkip = 0; 
    this.filter.rating = rating
    this.tripService.getHomeList(this.filter).subscribe(
      e => {
        this.items = e;
        this.loading = false
      })
  }

}

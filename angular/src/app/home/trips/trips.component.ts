import { Component, OnInit } from '@angular/core';
import { difficultyOptions, durationUnitOptions } from '@proxy';
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

  getEnumDiff(a) {
    return difficultyOptions.find(e => e.value == a).key
  }
  getEnumDuration(a) {
    return durationUnitOptions.find(e => e.value == a).key
  }
  ngOnInit(): void {
    this.loading = true
    this.tripService.getHomeList(20).subscribe(
      e => {
        this.items = e;
        this.loading = false
      })
  }

}

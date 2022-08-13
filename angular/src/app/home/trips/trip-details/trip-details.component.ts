import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { TripService } from '@proxy/app-services';
import { TripDto } from '@proxy/models';

@Component({
  selector: 'app-trip-details',
  templateUrl: './trip-details.component.html',
  styleUrls: ['./trip-details.component.scss']
})
export class TripDetailsComponent implements OnInit {
  tripItem: TripDto
  constructor(public tripService: TripService, private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.route.paramMap.subscribe(paramMap => {

      this.tripService.getTripWithDetails(paramMap.get('id')).subscribe(
        e => this.tripItem = e
      )
    })

  }

}

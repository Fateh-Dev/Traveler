import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-trip-item',
  templateUrl: './trip-item.component.html',
  styleUrls: ['./trip-item.component.scss']
})
export class TripItemComponent implements OnInit {
  @Input()
  title
  @Input()
  picUrl

  constructor() { }

  ngOnInit(): void {
  }

}

import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class TripService {

  constructor(public http: HttpClient) { }
  getTrips() {
    return this.http.get("https://localhost:44384/api/app/trip")
  }
}

import { AuthService } from '@abp/ng.core';
import { Component, HostListener } from '@angular/core';
import { OAuthService } from 'angular-oauth2-oidc';

import { Directive, ElementRef } from '@angular/core';
import { Trip, TripDto, TripMiniDto } from '@proxy/models';
import { TripService } from '@proxy/app-services/trip.service';

@Directive({ selector: 'img' })
export class LazyImgDirective {
  constructor({ nativeElement }: ElementRef<HTMLImageElement>) {
    const supports = 'loading' in HTMLImageElement.prototype;

    if (supports) {
      nativeElement.setAttribute('loading', 'lazy');
    }
  }
}
@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss'],
})
export class HomeComponent {
  get hasLoggedIn(): boolean {
    return this.oAuthService.hasValidAccessToken();
  }
  loading = false;
  items: TripMiniDto[] = [];
  constructor(
    private oAuthService: OAuthService,
    private authService: AuthService,
    public tripService: TripService) {

  }

  login() {
    this.authService.navigateToLogin();
  }

  ngOnInit() {
    this.loading = true
    this.tripService.getHomeList(5).subscribe(
      e => {
        this.items = e;
        this.loading = false
      })
  }
}

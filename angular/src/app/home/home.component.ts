import { AuthService } from '@abp/ng.core';
import { Component, HostListener } from '@angular/core';
import { OAuthService } from 'angular-oauth2-oidc';

import { Directive, ElementRef } from '@angular/core';
import { TripService } from './trip.service';

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
  items = [
    { title: 'Ziama Mansouriah', picUrl: 'images/9.jpg' },
    { title: 'Beni Bel3id', picUrl: 'images/10.jpg' },
    { title: 'El machaki', picUrl: 'images/6.jpg' },
    { title: 'Visit the Telemcen', picUrl: 'images/8.jpg' },
    { title: 'Visit Ghardaia', picUrl: 'images/7.jpg' }
  ]
  constructor(private oAuthService: OAuthService, private authService: AuthService, public tripService: TripService) { }

  login() {
    this.authService.navigateToLogin();
  }
  //  @HostListener('window:scroll', ['$event'])
  // onWindowScroll() {
  //   let element = document.querySelector('.tester') as HTMLElement;
  //   // console.log("client Heiehgt:", element.clientHeight)
  //   // console.log("window Offset:", window.pageYOffset)
  //   //TODO  Dynamic Opacity
  //   if (window.pageYOffset > element?.clientHeight) {
  //     element.classList.remove('bg-white/0');
  //     element.classList.add('bg-white/100');
  //     element.classList.add('shadow-md');
  //   }
  //   else {
  //     // element.classList.remove('bg-white');
  //     element.classList.remove('bg-white/100');
  //     element.classList.add('bg-white/0');

  //     element.classList.remove('shadow-md');
  //   }
  // }
  ngOnInit() {
    this.tripService.getTrips().subscribe(
      e => console.log((e as any).items)
    )
  }
}

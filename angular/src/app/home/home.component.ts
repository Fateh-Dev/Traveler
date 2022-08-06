import { AuthService } from '@abp/ng.core';
import { Component, HostListener } from '@angular/core';
import { OAuthService } from 'angular-oauth2-oidc';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss'],
})
export class HomeComponent {
  get hasLoggedIn(): boolean {
    return this.oAuthService.hasValidAccessToken();
  }

  constructor(private oAuthService: OAuthService, private authService: AuthService) {}

  login() {
    this.authService.navigateToLogin();
  } @HostListener('window:scroll', ['$event'])
  onWindowScroll() {
    let element = document.querySelector('.tester') as HTMLElement;
    // console.log("client Heiehgt:", element.clientHeight)
    // console.log("window Offset:", window.pageYOffset)
    //TODO  Dynamic Opacity
    if (window.pageYOffset > element.clientHeight) {
      element.classList.remove('bg-white/0');
      element.classList.add('bg-white/100');
      element.classList.add('shadow-md');
    }
    else {
      // element.classList.remove('bg-white');
      element.classList.remove('bg-white/100');
      element.classList.add('bg-white/0');

      element.classList.remove('shadow-md');
    }
  }
}

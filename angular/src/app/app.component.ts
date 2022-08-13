import { AuthService } from '@abp/ng.core';
import { Component, HostListener } from '@angular/core';
import { OAuthService } from 'angular-oauth2-oidc';
@Component({
  selector: 'app-root',
  templateUrl: "app.component.html",
})
export class AppComponent {
  /**
   *
   */
  constructor() {


  }
  logOut() { }
  @HostListener('window:scroll', ['$event'])
  onWindowScroll() {
    let element = document.querySelector('.headerToolbar') as HTMLElement;
    if (window.pageYOffset > 5) {
      element.classList.remove('bg-white/0');
      element.classList.add('bg-white/30');
      element.classList.add('backdrop-blur-lg');
      element.classList.add('shadow-md');
    }
    else {
      element.classList.remove('bg-white/30');
      element.classList.remove('backdrop-blur-lg');
      element.classList.add('bg-white/0');
      element.classList.remove('shadow-md');
    }
  }

  ngOnInit() {
    console.log(window.pageYOffset)
  }
}

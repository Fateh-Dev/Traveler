import { Component, HostListener } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: "app.component.html",
})
export class AppComponent {
  @HostListener('window:scroll', ['$event'])
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

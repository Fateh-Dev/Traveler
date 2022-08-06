import { CoreModule } from '@abp/ng.core';
import { NgbDropdownModule } from '@ng-bootstrap/ng-bootstrap';
import { NgModule } from '@angular/core';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { NgxValidateCoreModule } from '@ngx-validate/core';
import { BrowserModule } from '@angular/platform-browser';
import { CommonModule } from '@angular/common';

@NgModule({
  declarations: [],
  imports: [
    CoreModule,
    ThemeSharedModule,
    NgbDropdownModule, CommonModule,
    NgxValidateCoreModule, BrowserModule
  ],
  exports: [
    CoreModule,
    ThemeSharedModule, CommonModule,
    NgbDropdownModule,
    NgxValidateCoreModule, BrowserModule
  ],
  providers: []
})
export class SharedModule {}

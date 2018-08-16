import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SomePipe } from './pipes/some.pipe';
import { SomeDirective } from './directives/some.directive';

@NgModule({
  imports: [
    CommonModule
  ],
  declarations: [SomePipe, SomeDirective],
  exports: [
    CommonModule,
    SomePipe,
    SomeDirective
  ]
})
export class SharedModule { }

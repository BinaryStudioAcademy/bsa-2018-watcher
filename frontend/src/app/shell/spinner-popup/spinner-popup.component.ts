import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-spinner-popup',
  templateUrl: './spinner-popup.component.html',
  styleUrls: ['./spinner-popup.component.sass']
})
export class SpinnerPopupComponent implements OnInit {

  @Input() header: String;
  @Input() display: Boolean = false;

  constructor() { }

  ngOnInit() {
  }

}

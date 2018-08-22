import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'user-picture',
  templateUrl: './user-picture.component.html',
  styleUrls: ['./user-picture.component.sass']
})
export class UserPictureComponent implements OnInit {
  @Input() pictureUrl;

  constructor() { }

  ngOnInit() {
  }

}

import { Component, OnInit } from '@angular/core';
import { MenuItem } from 'primeng/api';

@Component({
  selector: 'app-edit-list',
  templateUrl: './edit-list.component.html',
  styleUrls: ['./edit-list.component.sass']
})
export class EditListComponent implements OnInit {

  constructor() { }

  editItems: MenuItem[];

  ngOnInit() {
    this.editItems = [{
      label: 'Profile'
    },
    {
      label: 'Notification Settings'
    }];
  }

}

import {Component, OnInit} from '@angular/core';
import {MenuItem, MessageService} from 'primeng/api';

@Component({
  selector: 'app-instance-list',
  templateUrl: './instance-list.component.html',
  styleUrls: ['./instance-list.component.sass'],
})
export class InstanceListComponent implements OnInit {

  constructor() {
  }

  menuItems: MenuItem[];

  ngOnInit() {
    this.menuItems = [
      {
        label: 'Create Instance',
        icon: 'pi pi-pw pi-plus',
      },
      {
        label: 'Instance1',
        icon: 'fa fa-fw fa-hdd-o',
        items: [
          {label: 'New', icon: 'fa fa-plus'},
          {label: 'Open', icon: 'fa fa-download'}
      ]
      },
      {
        label: 'Instance2',
        icon: 'fa fa-fw fa-hdd-o'
      }
    ];
  }
}

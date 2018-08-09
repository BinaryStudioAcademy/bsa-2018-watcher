import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-create-edit-dashboard',
  templateUrl: './create-edit-dashboard.component.html',
  styleUrls: ['./create-edit-dashboard.component.sass']
})
export class CreateEditDashboardComponent implements OnInit {

  display = false;
  dashboardTitle: string;
  creation = false;
  updating = false;

  constructor() { }

  closeDialog() {
    this.display = false;
  }

  onSave() {
    console.log(this.dashboardTitle);
    console.log(new Date());
    this.display = false;
  }
  showDialog() {
      this.display = true;
  }

  onHide() {
  }
  onShow() {
    if (this.updating !== true) {
    this.dashboardTitle = '';
  }}

  ngOnInit() {
  }
}

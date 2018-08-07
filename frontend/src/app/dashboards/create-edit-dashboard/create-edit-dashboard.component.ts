import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-create-edit-dashboard',
  templateUrl: './create-edit-dashboard.component.html',
  styleUrls: ['./create-edit-dashboard.component.sass']
})
export class CreateEditDashboardComponent implements OnInit {

  display: Boolean = false;
  dashboardTitle =  '';
  dashboardInstance = '';


  constructor() { }

  ngOnInit() {
  }

  showDialog() {
      this.display = true;
  }

}

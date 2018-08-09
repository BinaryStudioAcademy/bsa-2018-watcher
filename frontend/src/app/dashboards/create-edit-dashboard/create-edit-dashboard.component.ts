import { Component, OnInit, Output, Input } from '@angular/core';
import { EventEmitter } from '@angular/core';

@Component({
  selector: 'app-create-edit-dashboard',
  templateUrl: './create-edit-dashboard.component.html',
  styleUrls: ['./create-edit-dashboard.component.sass']
})
export class EditDashboardComponent implements OnInit {

  @Output() saved = new EventEmitter<string>();

  @Input() display = false;
  dashboardTitle: string;
  @Input() creation = false;

  constructor() { }

  closeDialog() {
    this.display = false;
  }

  Save() {
    this.saved.emit(this.dashboardTitle.slice());
    this.display = false;
  }
  showDialog() {
      this.display = true;
  }

  onHide() {
  }
  onShow() {
  }

  ngOnInit() {
  }
}

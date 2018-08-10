import { Component, OnInit, Output, Input } from '@angular/core';
import { EventEmitter } from '@angular/core';

@Component({
  selector: 'app-create-edit-dashboard',
  templateUrl: './create-edit-dashboard.component.html',
  styleUrls: ['./create-edit-dashboard.component.sass']
})
export class EditDashboardComponent implements OnInit {

  @Output() saved = new EventEmitter<string>();
  @Output() closed = new EventEmitter();
  @Input() display: boolean;
  @Input() dashboardTitle: string;
  constructor() { }

  closeDialog() {
    this.closed.emit();
  }

  Save() {
    this.saved.emit(this.dashboardTitle.slice());
  }
  ngOnInit() {
  }
}

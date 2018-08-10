import { Component, OnInit, OnChanges, Output, Input } from '@angular/core';
import { EventEmitter } from '@angular/core';

@Component({
  selector: 'app-create-edit-dashboard',
  templateUrl: './create-edit-dashboard.component.html',
  styleUrls: ['./create-edit-dashboard.component.sass']
})
export class EditDashboardComponent implements OnInit, OnChanges {

  title = '';

  @Output() saved = new EventEmitter<string>();
  @Output() closed = new EventEmitter();
  @Input() display: boolean;
  @Input() dashboardTitle: string;
  constructor() { }

  closeDialog() {
    this.closed.emit();
    this.dashboardTitle = '';
  }

  Save() {
    this.saved.emit(this.title);
  }

  ngOnChanges(changes) {
    this.title = changes.dashboardTitle && changes.dashboardTitle.currentValue;
  }

  ngOnInit() {
  }
}

import { Component, OnInit, OnChanges, Output, Input } from '@angular/core';
import { EventEmitter } from '@angular/core';

@Component({
  selector: 'app-edit-dashboard',
  templateUrl: './editDashboard.component.html',
  styleUrls: ['./editDashboard.component.sass']
})
export class EditDashboardComponent implements OnInit, OnChanges {

  title = '';

  @Output() edited = new EventEmitter<string>();
  @Output() closed = new EventEmitter();
  @Input() display: boolean;
  @Input() dashboardTitle: string;
  constructor() { }

  closeDialog(): void {
    this.closed.emit();
    this.dashboardTitle = '';
  }

  edit(): void {
    this.edited.emit(this.title);
  }

  ngOnChanges(changes) {
    this.title = changes.dashboardTitle && changes.dashboardTitle.currentValue;
  }

  ngOnInit() {
  }
}

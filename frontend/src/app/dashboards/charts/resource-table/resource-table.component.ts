import { Component, OnInit, Input, OnChanges } from '@angular/core';

import { DataProperty, dataPropertyLables } from '../../../shared/models/data-property.enum';
import { DashboardChart } from '../../models/dashboard-chart';
import { CollectedData } from '../../../shared/models/collected-data.model';


@Component({
  selector: 'app-resource-table',
  templateUrl: './resource-table.component.html',
  styleUrls: ['./resource-table.component.sass']
})
export class ResourceTableComponent implements OnInit, OnChanges {

  @Input() sources: DataProperty[];
  @Input() data: any; // CollectedData;

  labels = dataPropertyLables;
  property = DataProperty;
  constructor() { }

  ngOnInit() {
  }

  ngOnChanges(changes) {
  }
}

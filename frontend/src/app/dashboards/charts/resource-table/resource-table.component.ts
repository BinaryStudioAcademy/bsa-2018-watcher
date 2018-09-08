import { Component, OnInit, Input, OnChanges } from '@angular/core';

import { DataProperty, dataPropertyLables } from '../../../shared/models/data-property.enum';
import { DashboardChart } from '../../models/dashboard-chart';
import { CollectedData } from '../../../shared/models/collected-data.model';


@Component({
  selector: 'app-resource-table',
  templateUrl: './resource-table.component.html',
  styleUrls: ['./resource-table.component.sass']
})
export class ResourceTableComponent {

  @Input() sources: DataProperty[];
  @Input() data: any; // CollectedData;

  labels = dataPropertyLables;
  property = DataProperty;
  constructor() { }

  getColor(percent: number) {
    return 'rgba(' + [255, 255 - percent * 4, 255 - percent * 18, 0.6].join(',') + ')';
  }

  floorIfNumber(value) {
    const result = isNaN(value);
    if (result) {
      return value;
    }

    return Math.round(value * 100) / 100;
  }
}

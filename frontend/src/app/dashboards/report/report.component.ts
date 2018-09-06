import { Component, OnInit, ViewChild } from '@angular/core';
import { AggregatedDataService } from '../../core/services/aggregated-data.service';
import { ActivatedRoute } from '@angular/router';
import { DataType } from '../../shared/models/data-type.enum';
import { CollectedData } from '../../shared/models/collected-data.model';
import { AggregateDataRequest } from '../../shared/models/aggregate-data-request.model';
import { SelectItem } from 'primeng/api';
import { Calendar } from 'primeng/primeng';

@Component({
  selector: 'app-report',
  templateUrl: './report.component.html',
  styleUrls: ['./report.component.sass']
})
export class ReportComponent implements OnInit {

  @ViewChild('cf') calendarFilter: Calendar;

  private id: string;

  collectedData: CollectedData[];

  types: SelectItem[];
  selectedType: DataType;

  dates: Date[];

  cols: any[];

  constructor(private aggregatedDateService: AggregatedDataService,
              private activateRoute: ActivatedRoute) { }

  ngOnInit() {
    this.cols = [
      { field: 'name', header: 'Name' },
      { field: 'pCpu', header: 'CPU,%' },
      { field: 'pRam', header: 'RAM, %' },
      { field: 'ramMBytes', header: 'RAM, Mb' }
    ];

    this.types = [
      { label: 'AggregationForHour', value: DataType.AggregationForHour },
      { label: 'AggregationForDay', value: DataType.AggregationForDay },
      { label: 'AggregationForWeek', value: DataType.AggregationForWeek },
      { label: 'AggregationForMonth', value: DataType.AggregationForMonth }
    ];

    this.calendarFilter.showTime = true;

    this.dates = [new Date(Date.now())];

    const x = this.activateRoute.params.subscribe(params => {
      this.id = params['guidId'];
    });
  }

  changeType(ev): void {
    switch (DataType[ev.value]) {
      case 'AggregationForHour':
        this.calendarFilter.showTime = true;
        break;
      case 'AggregationForDay':
        this.calendarFilter.showTime = false;
        break;
      case 'AggregationForWeek':
        this.calendarFilter.showTime = false;
        break;
      case 'AggregationForMonth':
        this.calendarFilter.showTime = false;
        break;
    }
  }

  getInfo(): void {
    const request: AggregateDataRequest = {
      id: this.id,
      type: this.selectedType,
      from: this.dates[0],
      to: this.dates[this.dates.length - 1]
    };

    if (this.id) {
      this.aggregatedDateService.getDataByInstanceIdAndTypeInTime(request).subscribe((data: CollectedData[]) => {
        data.forEach(item => {
          item.time = new Date(item.time);
        });
        this.collectedData = data;
      });
    }
  }

}

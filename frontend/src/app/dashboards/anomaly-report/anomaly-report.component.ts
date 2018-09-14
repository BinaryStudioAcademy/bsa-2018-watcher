import { Component, OnInit, ViewChild } from '@angular/core';
import { SelectItem } from 'primeng/api';
import { DataType } from '../../shared/models/data-type.enum';
import { Calendar } from 'primeng/primeng';

@Component({
  selector: 'app-anomaly-report',
  templateUrl: './anomaly-report.component.html',
  styleUrls: ['./anomaly-report.component.sass']
})
export class AnomalyReportComponent implements OnInit {

  @ViewChild('cf1') calendarFilter1: Calendar;
  @ViewChild('cf2') calendarFilter2: Calendar;

  types: SelectItem[];
  selectedType: DataType;

  dateFrom: Date;
  dateTo: Date;

  constructor() { }

  ngOnInit() {
    this.types = [
      { label: 'Hourly', value: DataType.AggregationForHour },
      { label: 'Daily', value: DataType.AggregationForDay },
      { label: 'Weekly', value: DataType.AggregationForWeek },
      { label: 'Monthly', value: DataType.AggregationForMonth }
    ];

    this.selectedType = this.types[0].value;
  }

  changeType(ev): void {
    switch (DataType[ev.value]) {
      case 'AggregationForHour':
        this.calendarFilter1.showTime = true;
        this.calendarFilter2.showTime = true;
        break;
      case 'AggregationForDay':
        if (this.dateFrom && this.dateTo) {
          this.dateFrom.setHours(0);
          this.dateFrom.setMinutes(0);
          this.dateTo.setHours(0);
          this.dateTo.setMinutes(0);
        }
        this.calendarFilter1.showTime = false;
        this.calendarFilter2.showTime = false;
        break;
      case 'AggregationForWeek':
        if (this.dateFrom && this.dateTo) {
          this.dateFrom.setHours(0);
          this.dateFrom.setMinutes(0);
          this.dateTo.setHours(0);
          this.dateTo.setMinutes(0);
        }
        this.calendarFilter1.showTime = false;
        this.calendarFilter2.showTime = false;
        break;
      case 'AggregationForMonth':
        if (this.dateFrom && this.dateTo) {
          this.dateFrom.setHours(0);
          this.dateFrom.setMinutes(0);
          this.dateTo.setHours(0);
          this.dateTo.setMinutes(0);
        }
        this.calendarFilter1.showTime = false;
        this.calendarFilter2.showTime = false;
        break;
    }
  }

}

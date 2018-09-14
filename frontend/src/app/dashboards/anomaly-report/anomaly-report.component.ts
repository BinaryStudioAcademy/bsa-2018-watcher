import { Component, OnInit, ViewChild } from '@angular/core';
import { SelectItem } from 'primeng/api';
import { DataType } from '../../shared/models/data-type.enum';
import { Calendar } from 'primeng/primeng';
import { AnomalyReportService } from '../../core/services/anomaly-report.service';
import { InstanceAnomalyReport } from '../../shared/models/instance-anomaly-report.model';
import { ActivatedRoute } from '@angular/router';
import { AnomalyReportRequest } from '../../shared/models/anomaly-report-request.model';
import { ToastrService } from '../../core/services/toastr.service';

@Component({
  selector: 'app-anomaly-report',
  templateUrl: './anomaly-report.component.html',
  styleUrls: ['./anomaly-report.component.sass']
})
export class AnomalyReportComponent implements OnInit {

  @ViewChild('cf1') calendarFilter1: Calendar;
  @ViewChild('cf2') calendarFilter2: Calendar;

  id: string;

  types: SelectItem[];
  selectedType: DataType;

  dateFrom: Date;
  dateTo: Date;

  reports: InstanceAnomalyReport[];
  totalRecords: number;

  type: DataType;

  isGetting: boolean;

  constructor(private anomalyReportService: AnomalyReportService,
              private activateRoute: ActivatedRoute,
              private toastrService: ToastrService) { }

  ngOnInit() {
    this.types = [
      { label: 'Hourly', value: DataType.AggregationForHour },
      { label: 'Daily', value: DataType.AggregationForDay },
      { label: 'Weekly', value: DataType.AggregationForWeek },
      { label: 'Monthly', value: DataType.AggregationForMonth }
    ];

    this.selectedType = this.types[0].value;

    this.activateRoute.params.subscribe(params => {
      this.id = params['guidId'];
    });
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

  getInfo(): void {
    this.isGetting = true;
    this.anomalyReportService.getDataByInstanceIdAndTypeInTime(this.createRequest()).subscribe((data: InstanceAnomalyReport[]) => {
      data.forEach(item => {
        item.date = new Date(item.date);
        item.link = 'https://academy2018.slack.com/archives/DBQSQ5WVC/p1536933960000100';
      });
      this.reports = data;

      this.isGetting = false;
    });
  }

  private createRequest(): AnomalyReportRequest {
    return {
      id: this.id,
      type: this.selectedType,
      from: this.dateFrom,
      to: this.dateTo
    };
  }

  onCopy(link: string) {
    const selBox = document.createElement('textarea');
    selBox.style.position = 'fixed';
    selBox.style.left = '0';
    selBox.style.top = '0';
    selBox.style.opacity = '0';
    selBox.value = link;
    document.body.appendChild(selBox);
    selBox.focus();
    selBox.select();
    document.execCommand('copy');
    document.body.removeChild(selBox);
    this.toastrService.info('Link was copied to clipboard');
  }


}

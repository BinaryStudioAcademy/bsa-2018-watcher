import { Component, OnInit } from '@angular/core';
import { AggregatedDataService } from '../../core/services/aggregated-data.service';
import { ActivatedRoute } from '@angular/router';
import { DataType } from '../../shared/models/data-type.enum';
import { CollectedData } from '../../shared/models/collected-data.model';
import { AggregateDataRequest } from '../../shared/models/aggregate-data-request.model';

@Component({
  selector: 'app-report',
  templateUrl: './report.component.html',
  styleUrls: ['./report.component.sass']
})
export class ReportComponent implements OnInit {

  private id: string;

  collectedData: CollectedData[];

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

    const x = this.activateRoute.params.subscribe(params => {
      this.id = params['guidId'];

      const request: AggregateDataRequest = {
        id: this.id,
        type: DataType.AggregationForHour,
        from: new Date(2018, 8, 5, 0, 0),
        to: new Date(2018, 8, 6, 0, 0)
      };

      if (this.id) {
        this.aggregatedDateService.getDataByInstanceIdAndTypeInTime(request).subscribe((data: CollectedData[]) => {
          console.log(data);
          this.collectedData = data;
        });
      }
    });
  }

}

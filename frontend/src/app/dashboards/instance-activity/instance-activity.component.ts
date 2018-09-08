import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { CollectorLog } from '../../shared/models/collector-log.model';
import { CollectorLogService } from '../../core/services/collector-log.service';
import { CollectorLogLevel } from '../../shared/models/log-level.enum';

@Component({
  selector: 'app-instance-activity',
  templateUrl: './instance-activity.component.html',
  styleUrls: ['./instance-activity.component.sass']
})
export class InstanceActivityComponent implements OnInit {

  logs: CollectorLog[] = [];
  instanceId: string;

  constructor(private activateRoute: ActivatedRoute,
    private router: Router,
    private collectorLogService: CollectorLogService) { }

  ngOnInit() {
    this.activateRoute.params.subscribe(params => {
      this.instanceId = params['insId'];
      this.getLogs();
    });
  }

  getLogs() {
    if (this.instanceId) {
      this.collectorLogService.getAllLogs(this.instanceId).subscribe((data: CollectorLog[]) => {
        if (data) {
          console.log(data);
          this.logs = data.map(log =>
          Object.assign({}, log, {logLevelName: CollectorLogLevel[log.logLevel]}));
        }
      });
    }
  }

}

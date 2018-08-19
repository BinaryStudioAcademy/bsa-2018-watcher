import {Component, OnInit} from '@angular/core';
import {single, multi} from '../models';

@Component({
  selector: 'app-vertical-bar-chart',
  templateUrl: './vertical-bar-chart.component.html',
  styleUrls: ['./vertical-bar-chart.component.sass']
})
export class VerticalBarChartComponent implements OnInit {
  view: any[] = [700, 300];

  // options
  showXAxis = true;
  showYAxis = true;
  gradient = false;
  showLegend = true;
  showXAxisLabel = true;
  xAxisLabel = 'Country';
  showYAxisLabel = true;
  yAxisLabel = 'Population';

  colorScheme = {
    domain: ['#5AA454', '#A10A28', '#C7B42C', '#AAAAAA']
  };

  customColors = [
    {
      name: 'france',
      value: '#62ff41'
    }
  ];



  single: any[] = [
    {
      'name': 'Mexico',
      'series': [
        {
          'value': 1111,
          'name': '2016-09-24T22:03:52.377Z'
        },
        {
          'value': 2277,
          'name': '2016-09-22T22:03:52.377Z'
        },
        {
          'value': 5736,
          'name': '2016-09-18T04:51:54.573Z'
        },
        {
          'value': 3747,
          'name': '2016-09-20T23:21:10.372Z'
        },
        {
          'value': 5437,
          'name': '2016-09-20T20:55:49.594Z'
        },
        {
          'value': 6835,
          'name': '2016-09-16T08:38:13.120Z'
        }
      ]
    },
    {
      'name': 'Chile',
      'series': [
        {
          'value': 5001,
          'name': '2016-09-24T22:03:52.377Z'
        },
        {
          'value': 6054,
          'name': '2016-09-22T22:03:52.377Z'
        },
        {
          'value': 4631,
          'name': '2016-09-18T04:51:54.573Z'
        },
        {
          'value': 6292,
          'name': '2016-09-20T23:21:10.372Z'
        },
        {
          'value': 2775,
          'name': '2016-09-20T20:55:49.594Z'
        },
        {
          'value': 5247,
          'name': '2016-09-16T08:38:13.120Z'
        }
      ]
    },
    {
      'name': 'Morocco',
      'series': [
        {
          'value': 2000,
          'name': '2016-09-24T22:03:52.377Z'
        },
        {
          'value': 2603,
          'name': '2016-09-22T22:03:52.377Z'
        },
        {
          'value': 5766,
          'name': '2016-09-18T04:51:54.573Z'
        },
        {
          'value': 5975,
          'name': '2016-09-20T23:21:10.372Z'
        },
        {
          'value': 4712,
          'name': '2016-09-20T20:55:49.594Z'
        },
        {
          'value': 3066,
          'name': '2016-09-16T08:38:13.120Z'
        }
      ]
    },
    {
      'name': 'Myanmar',
      'series': [
        {
          'value': 4000,
          'name': '2016-09-24T22:03:52.377Z'
        },
        {
          'value': 5987,
          'name': '2016-09-22T22:03:52.377Z'
        },
        {
          'value': 4182,
          'name': '2016-09-18T04:51:54.573Z'
        },
        {
          'value': 5942,
          'name': '2016-09-20T23:21:10.372Z'
        },
        {
          'value': 6756,
          'name': '2016-09-20T20:55:49.594Z'
        },
        {
          'value': 6954,
          'name': '2016-09-16T08:38:13.120Z'
        }
      ]
    },
    {
      'name': 'Malta',
      'series': [
        {
          'value': 3000,
          'name': '2016-09-24T22:03:52.377Z'
        },
        {
          'value': 6024,
          'name': '2016-09-22T22:03:52.377Z'
        },
        {
          'value': 3599,
          'name': '2016-09-18T04:51:54.573Z'
        },
        {
          'value': 4461,
          'name': '2016-09-20T23:21:10.372Z'
        },
        {
          'value': 4490,
          'name': '2016-09-20T20:55:49.594Z'
        },
        {
          'value': 3790,
          'name': '2016-09-16T08:38:13.120Z'
        }
      ]
    }
  ];

  multi: any[];
  //
  // single: any[] = [
  //   {
  //     'name': 'Germany',
  //     'value': 8940000
  //   },
  //   {
  //     'name': 'USA',
  //     'value': 5000000
  //   },
  //   {
  //     'name': 'France',
  //     'value': 7200000
  //   }
  // ];

  // multi: any[] = [
  //   {
  //     "name": "Philippines",
  //     "series": [
  //       {
  //         "name": "1990",
  //         "value": 33880
  //       },
  //       {
  //         "name": "2000",
  //         "value": 49083
  //       },
  //       {
  //         "name": "2010",
  //         "value": 45123
  //       }
  //     ]
  //   },
  //   {
  //     "name": "Heard Island and Mcdonald Islands",
  //     "series": [
  //       {
  //         "name": "1990",
  //         "value": 25786
  //       },
  //       {
  //         "name": "2000",
  //         "value": 45361
  //       },
  //       {
  //         "name": "2010",
  //         "value": 39250
  //       }
  //     ]
  //   },
  //   {
  //     "name": "Spain",
  //     "series": [
  //       {
  //         "name": "1990",
  //         "value": 30017
  //       },
  //       {
  //         "name": "2000",
  //         "value": 25940
  //       },
  //       {
  //         "name": "2010",
  //         "value": 46230
  //       }
  //     ]
  //   },
  //   {
  //     "name": "Tuvalu",
  //     "series": [
  //       {
  //         "name": "1990",
  //         "value": 46796
  //       },
  //       {
  //         "name": "2000",
  //         "value": 43494
  //       },
  //       {
  //         "name": "2010",
  //         "value": 32221
  //       }
  //     ]
  //   }
  // ];

  constructor() {
    // Object.assign(this, {single, multi});
  }

  ngOnInit() {
  }

  onSelect(event) {
    console.log(event);
  }
}

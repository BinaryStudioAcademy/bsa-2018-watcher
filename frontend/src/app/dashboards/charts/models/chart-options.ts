import {colorSets} from '@swimlane/ngx-charts/release/utils';
import * as shape from 'd3-shape';
import {CustomChart} from './custom-chart';

export const defaultOptions = {
  view: [716, 337],
  // colorScheme:  {
  //   domain: ['#5AA454', '#A10A28', '#C7B42C', '#AAAAAA']
  // },
  colorScheme: colorSets.find(s => s.name === 'cool'),
  schemeType: 'ordinal',
  showLegend: true,
  legendTitle: 'Legend',
  gradient: false,
  showXAxis: true,
  showYAxis: true,
  showXAxisLabel: true,
  showYAxisLabel: true,
  yAxisLabel: '',
  xAxisLabel: '',
  autoScale: true,
  showGridLines: true,
  rangeFillOpacity: 0.5,
  roundDomains: false,
  tooltipDisabled: false,
  showSeriesOnHover: true,
  curve: shape.curveLinear,
  curveClosed: shape.curveCardinalClosed
} as CustomChart;

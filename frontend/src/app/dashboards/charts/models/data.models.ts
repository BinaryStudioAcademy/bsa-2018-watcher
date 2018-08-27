export interface ChartType {
  name: string;
  title: string;
  dimLabels: string[];
  chartLabels: Function;
}

export interface Chart {
  view: any;
  colorScheme: any;
  schemeType: string;
  showLegend: boolean;
  legendTitle: string;
  gradient: boolean;
  showXAxis: boolean;
  showYAxis: boolean;
  showXAxisLabel: boolean;
  showYAxisLabel: boolean;
  yAxisLabel: string;
  xAxisLabel: string;
  autoScale: boolean;
  showGridLines: boolean;
  rangeFillOpacity: 0.5;
  roundDomains: boolean;
  tooltipDisabled: boolean;
  showSeriesOnHover: boolean;
  curve: any;
  curveClosed: any;

  title: string;

  dataDims: string[];
  xQuery: any;
  yQuery: any;
  xFilter: Filter;
  yFilter: Filter;

  data: Data[];
  activeEntries: Data[];
  chartType: ChartType;
  theme: string;
}

export interface Filter {
  type: string;
  key: string;
  label: string;
  minValue: any;
  maxValue: any;
  query: Query;
  step: number;
  values: Data[];
  rangeIndex: Data;
  range: number[];
}

export interface Data {
  [x: string]: any;
}

// universe types
export interface Universe {
  query: any;
  filter: any;
}

export interface Query {
  data: Data[];
  column: any;
}

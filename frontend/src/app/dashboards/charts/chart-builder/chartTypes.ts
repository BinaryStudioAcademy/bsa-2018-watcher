// import { toCapitalizedWords } from '../utils';

import {ChartType} from '../models/data.models';

function createChartType({title, ...obj}): ChartType {
  return {
    title,
    name: titleToName(title),
    dimLabels: ['Group by', 'Name', 'Value', null],
    ...obj
  } as ChartType;

  function titleToName(s: string) {
    return s.toLowerCase().replace(/\ /g, '-');
  }
}

const singleDimLables = ['Group by', null, 'Value', null, 'Aggregation'];
const multiDimLables = ['Group by', 'Name', 'Value', null, 'Aggregation'];
const lineChartLabels = ['Group by', 'x-Values', 'y-Values', null, 'Aggregation'];


const singleChartLables = ([group, name, value, value2, agg]) => {
  return {
    xAxisLabel: group,
    yAxisLabel: `${agg} of ${value}`,
    legendTitle: group,
    title: `${agg} of ${value} vs ${group}`
  };
};

const multiChartLables = ([group, name, value, value2, agg]) => {
  return {
    xAxisLabel: `${name} by ${group}`,
    yAxisLabel: `${agg} of ${value}`,
    legendTitle: name,
    title: `${agg} of ${value} vs ${name} by ${group}`
  };
};

const singleChartLablesInv = ([group, name, value, value2, agg]) => {
  return {
    xAxisLabel: `${agg} of ${value}`,
    yAxisLabel: group,
    legendTitle: group,
    title: `${agg} of ${value} vs ${group}`
  };
};

const multiChartLablesInv = ([group, name, value, value2, agg]) => {
  return {
    xAxisLabel: `${agg} of ${value}`,
    yAxisLabel: `${name} by ${group}`,
    legendTitle: name,
    title: `${agg} of ${value} vs ${name} by ${group}`
  };
};

const cardsLables = ([group, name, value, value2, agg]) => {
  return {
    xAxisLabel: group,
    yAxisLabel: `${agg} of ${value}`,
    legendTitle: group,
    title: `${agg} of ${value} by ${group}`
  };
};

const heatMapChartLables = ([group, name, value, value2, agg]) => {
  return {
    xAxisLabel: group,
    yAxisLabel: name,
    legendTitle: `${agg} of ${value}`,
    title: `${agg} of ${value}`
  };
};

const lineChartLables = ([group, name, value, value2, agg]) => {
  return {
    xAxisLabel: name,
    yAxisLabel: `${agg} of ${value}`,
    legendTitle: group,
    title: `${agg} of ${value} vs ${name}`
  };
};


export const chartTypes = [
  createChartType({
    title: 'Bar Vertical',
    dimLabels: singleDimLables,
    chartLabels: singleChartLables
  }),
  createChartType({
    title: 'Bar Horizontal',
    dimLabels: singleDimLables,
    chartLabels: singleChartLablesInv
  }),
  createChartType({
    title: 'Pie',
    dimLabels: singleDimLables,
    chartLabels: singleChartLables
  }),
  createChartType({
    title: 'Tree Map',
    dimLabels: singleDimLables,
    chartLabels: cardsLables
  }),
  createChartType({
    title: 'Number Cards',
    dimLabels: singleDimLables,
    chartLabels: cardsLables
  }),
  createChartType({
    title: 'Guage',
    dimLabels: singleDimLables,
    chartLabels: cardsLables
  }),
  createChartType({
    title: 'Pie Grid',
    dimLabels: singleDimLables,
    chartLabels: cardsLables
  }),
  createChartType({
    title: 'Line Chart',
    dimLabels: lineChartLabels,
    chartLabels: lineChartLables
  }),
  createChartType({
    title: 'Bar Vertical 2D',
    dimLabels: multiDimLables,
    chartLabels: multiChartLables
  }),
  createChartType({
    title: 'Bar Horizontal 2D',
    dimLabels: multiDimLables,
    chartLabels: multiChartLablesInv
  }),
  /* createChartType({
    title: 'Bar Vertical Stacked',
    dimLabels: multiDimLables,
    chartLabels: singleChartLables
  }),
  createChartType({
    title: 'Bar Vertical Normalized',
    dimLabels: multiDimLables,
    chartLabels: singleChartLables
  }),
  createChartType({
    title: 'Bar Horizontal Normalized',
    dimLabels: multiDimLables,
    chartLabels: singleChartLables
  }), */
  createChartType({
    title: 'Polar Chart',
    dimLabels: ['Group by', 'Angle Values', 'Radius Values', null, 'Aggregation'],
    chartLabels: multiChartLables
  }),
  createChartType({
    title: 'Heat Map',
    dimLabels: ['x-Category', 'y-Category', 'Color', null, 'Aggregation'],
    chartLabels: heatMapChartLables
  }),
  /* createChartType({
    title: 'Bubble Chart',
    dimLabels: ['GroupBy', 'x-Values', 'y-Values', 'Radius', 'Aggregation'],
    chartLabels: singleChartLables
  }) */
];

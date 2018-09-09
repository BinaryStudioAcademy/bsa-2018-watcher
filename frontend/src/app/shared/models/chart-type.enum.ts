import {ProperiesMap} from './map';

export enum ChartType {
    BarVertical = 0,
    LineChart,
    Pie,
    Guage,
    NumberCards,
    ResourcesTable,
    PolarChart,
    AreaChart,
    AreaChartStacked,
    AreaChartNormalized,
    AdvancedPie,
    PieGrid,
    TreeMap
}

export const chartTypeLabels: ProperiesMap<string> = {};
chartTypeLabels[ChartType.BarVertical] = 'Bar Vertical';
chartTypeLabels[ChartType.LineChart] = 'Line Chart';
chartTypeLabels[ChartType.Pie] = 'Pie';
chartTypeLabels[ChartType.AdvancedPie] = 'Advanced Pie';
chartTypeLabels[ChartType.PieGrid] = 'Pie Grid';
chartTypeLabels[ChartType.Guage] = 'Guage';
chartTypeLabels[ChartType.NumberCards] = 'Number Cards';
chartTypeLabels[ChartType.ResourcesTable] = 'Resources Table';
chartTypeLabels[ChartType.PolarChart] = 'Polar Chart';
chartTypeLabels[ChartType.AreaChart] = 'Area Chart';
chartTypeLabels[ChartType.AreaChartStacked] = 'Area Stacked Chart';
chartTypeLabels[ChartType.AreaChartNormalized] = 'Area Normalized Chart';
chartTypeLabels[ChartType.TreeMap] = 'Tree Map';

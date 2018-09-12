import {ProperiesMap} from './map';

export enum ChartType {
    BarVertical = 0,
    LineChart,
    Pie,
    Gauge,
    NumberCards,
    ResourcesTable,
    PolarChart,
    AreaChart,
    AreaChartStacked,
    AreaChartNormalized,
    AdvancedPie,
    PieGrid,
    TreeMap,
    HeatMap,
    BarHorizontal,
    BarVertical2D,
    BarHorizontal2D,
    BarVerticalStacked,
    BarHorizontalStacked,
    BarVerticalNormalized,
    BarHorizontalNormalized
}

export const chartTypeLabels: ProperiesMap<string> = {};

chartTypeLabels[ChartType.LineChart] = 'Line Chart';

chartTypeLabels[ChartType.BarVertical] = 'Bar Vertical';
chartTypeLabels[ChartType.BarVertical2D] = 'Bar Vertical 2D';
chartTypeLabels[ChartType.BarVerticalStacked] = 'Bar Vertical Stacked';
chartTypeLabels[ChartType.BarVerticalNormalized] = 'Bar Vertical Normalized';

chartTypeLabels[ChartType.BarHorizontal] = 'Bar Horizontal';
chartTypeLabels[ChartType.BarHorizontal2D] = 'Bar Horizontal 2D';
chartTypeLabels[ChartType.BarHorizontalStacked] = 'Bar Horizontal Stacked';
chartTypeLabels[ChartType.BarHorizontalNormalized] = 'Bar Horizontal Normalized';

chartTypeLabels[ChartType.Pie] = 'Pie';
chartTypeLabels[ChartType.PieGrid] = 'Pie Grid';
chartTypeLabels[ChartType.AdvancedPie] = 'Advanced Pie';

chartTypeLabels[ChartType.AreaChart] = 'Area Chart';
chartTypeLabels[ChartType.AreaChartStacked] = 'Area Stacked Chart';
chartTypeLabels[ChartType.AreaChartNormalized] = 'Area Normalized Chart';

chartTypeLabels[ChartType.ResourcesTable] = 'Resources Table';
chartTypeLabels[ChartType.Gauge] = 'Gauge';
chartTypeLabels[ChartType.NumberCards] = 'Number Cards';
chartTypeLabels[ChartType.PolarChart] = 'Polar Chart';
chartTypeLabels[ChartType.TreeMap] = 'Tree Map';
chartTypeLabels[ChartType.HeatMap] = 'Heat Map';

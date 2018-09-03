import {PercentageInfo} from '../../dashboards/models/percentage-info';


export interface CollectedData extends PercentageInfo {
   id: string;
   time: Date;
   processesCount: number;
   processesCPU: { [key: string]: number; };
   processesRAM: { [key: string]: number; };
   cpuUsagePercent: number;
   ramUsagePercent: number;
   interruptsTimePercent: number;
   localDiskFreeSpacePercent: number;
   avaliableRamBytes: number;
   interruptsPerSeconds: number;
   localDiskFreeMBytes: number;
}




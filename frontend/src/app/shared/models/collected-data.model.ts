import {PercentageInfo} from '../../dashboards/models/percentage-info';
import { ProcessData } from './process-data.model';


export interface CollectedData extends PercentageInfo {
   id: string;
   time: Date;
   processesCount: number;
   processes: ProcessData[];
   cpuUsagePercent: number;
   ramUsagePercent: number;
   interruptsTimePercent: number;
   localDiskFreeSpacePercent: number;
   avaliableRamBytes: number;
   interruptsPerSeconds: number;
   localDiskFreeMBytes: number;
}




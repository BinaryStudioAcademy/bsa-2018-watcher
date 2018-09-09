
import { CollectedDataType } from './collected-data-type.enum';
import { ProcessData } from './process-data.model';

export interface CollectedData  {
   id: string;
   clientId: string;
   collectedDataType: CollectedDataType;
   processesCount: number;
   processes: ProcessData[];
   freeRamMBytes: number;
   totalRamMBytes: number;
   freeRamPercentage: number;
   interruptsPerSeconds: number;
   localDiskFreeMBytes: number;
   localDiskTotalMBytes: number;
   localDiskFreePercentage: number;
   time: Date;
}




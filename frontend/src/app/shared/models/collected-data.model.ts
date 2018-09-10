import {CollectedDataType} from './collected-data-type.enum';
import {ProcessData} from './process-data.model';

export interface CollectedData {
  id: string;
  clientId: string;
  collectedDataType: CollectedDataType;
  processesCount: number;
  processes: ProcessData[];
  usageRamMBytes: number;
  totalRamMBytes: number;
  ramUsagePercentage: number;
  interruptsPerSeconds: number;
  localDiskUsageMBytes: number;
  localDiskTotalMBytes: number;
  localDiskUsagePercentage: number;
  cpuUsagePercentage: number;
  time: Date;
}

export const defaultCollectedData: CollectedData = {
  id: '0',
  clientId: '0',
  collectedDataType: CollectedDataType.Accumulation,
  processesCount: 0,
  processes: [],
  usageRamMBytes: 0,
  totalRamMBytes: 0,
  ramUsagePercentage: 0,
  interruptsPerSeconds: 0,
  localDiskUsageMBytes: 0,
  localDiskTotalMBytes: 0,
  localDiskUsagePercentage: 0,
  cpuUsagePercentage: 0,
  time: new Date()
};




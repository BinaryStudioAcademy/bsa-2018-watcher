import { DataType } from './data-type.enum';
import { AzureMLAnomalyGroup } from './azureML-anomaly-group.model';

export interface InstanceAnomalyReport  {
    id: string;
    clientId: string;
    date: Date;
    collectedDataTypeOfReport: DataType;
    anomalyGroups: AzureMLAnomalyGroup[];
    htmlDocUrl: string;
}



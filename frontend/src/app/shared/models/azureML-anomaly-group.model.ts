import { AzureMLAnomaly } from './azureML-anomaly.model';

export interface AzureMLAnomalyGroup  {
    name: string;
    warnings: AzureMLAnomaly[];
    Anomalies: AzureMLAnomaly[];
    total: number;
}

import { DataType } from './data-type.enum';

export interface AnomalyReportRequest {
    id: string;
    type: DataType;
    from: Date;
    to: Date;
}

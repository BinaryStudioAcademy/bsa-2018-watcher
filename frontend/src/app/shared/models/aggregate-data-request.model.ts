import { DataType } from './data-type.enum';

export interface AggregateDataRequest {
    id: string;
    type: DataType;
    from: Date;
    to: Date;
}


import { OrderBy } from './order-by.enum';

export interface Filter  {
   pageSize: number;
   page: number;
   orderBy: OrderBy;
   searchString: string;
}




import {SampleEnum} from './sample-enum.enum';

export interface SampleRequest {
  name: string;
  count: number;
  dateOfCreation: Date;
  sampleField: SampleEnum;
}

import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'enumAsString'
})
export class EnumAsString implements PipeTransform {

  transform(value: number, enumType: any): any {
      return enumType[value].split(/(?=[A-Z])/).join().replace(',', ' ');
  }

}

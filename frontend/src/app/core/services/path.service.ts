import { Injectable } from '@angular/core';
import { environment } from '../../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class PathService {

  constructor() { }

  public convertToUrl(filePath: string): string {

    const firstSymbols = filePath.slice(0, 7);
    if (firstSymbols === 'images/') {
      filePath = `${environment.server_url}/${filePath}`;
    }
    return filePath;
  }
}

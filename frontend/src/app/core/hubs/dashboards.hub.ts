import {EventEmitter, Injectable} from '@angular/core';
import { HubConnection} from '@aspnet/signalr';
import * as signalR from '@aspnet/signalr';
import {environment} from '../../../environments/environment';
import {SampleDto} from '../../shared/models/sample-dto.model';
import {SampleRequest} from '../../shared/models/sample-request.model';
import {MarketPrice, MarketPriceDate} from '../../dashboards/models';
import {from, Observable, Subject} from 'rxjs';
import {PercentageInfo} from '../../dashboards/models/percentage-info';
import {ApiService} from '../services/api.service';
import {AuthService} from '../services/auth.service';


@Injectable({
  providedIn: 'root'
})
export class DashboardsHub {
  private connectionIsEstablished = false;
  private hubConnection: HubConnection | undefined;
  private marketSub = new Subject<MarketPriceDate>();
  public marketSubObservable = from(this.marketSub);

  private infoSub = new Subject<PercentageInfo>();
  public infoSubObservable = from(this.infoSub);

  sampleReceived = new EventEmitter<SampleDto>();
  connectionEstablished = new EventEmitter<Boolean>();

  constructor(private apiService: ApiService,
              private authService: AuthService) {
  }

  public getInitialMarketStatusOld(): Observable<MarketPrice[]> {
    return this.apiService.get(`/Samples/MarketData`) as Observable<MarketPrice[]>;
  }

  public getInitialMarketStatus(): Observable<MarketPriceDate[]> {
    return this.apiService.get(`/Samples/MarketData`) as Observable<MarketPriceDate[]>;
  }

  public getInitialPercentageInfo(): Observable<PercentageInfo[]> { // TODO: For Line Chart
    // Get first instance
    const iId = '7FE193DE-B3DC-4DF5-8646-A81EDBE047E2'; // this.authService.getCurrentUser().lastPickedOrganization.instancesId[0];
    return this.apiService.get(`/CollectedData/Percentage/${iId}?count=20`) as Observable<PercentageInfo[]>;
  }

  connectToSignalR(): void {
    this.createConnection();
    this.registerOnServerEvents();
    this.startHubConnection();
  }

  subscribeToMarketDataFeed() {
    if (this.hubConnection) {
      this.hubConnection.invoke('SubscribeToMarketDataFeed')
        .catch(err => console.error(err));
    }
  }

  subscribeToInstanceById(instanceGuidId: string): void {
    if (this.hubConnection) {
      this.hubConnection.invoke('SubscribeToInstanceById', instanceGuidId)
        .catch(err => console.error(err));
    }
  }

  send(userId: string, item: string): string {
    if (this.hubConnection) {
      this.hubConnection.invoke('Send', userId, item)
        .catch(err => console.error(err));
    }
    return item;
  }

  createSample(request: SampleRequest): SampleRequest {
    if (this.hubConnection) {
      this.hubConnection.invoke('CreateSample', request)
        .catch(err => console.error(err));
    }
    return request;
  }

  sendMessage(mess: string): string {
    if (this.hubConnection) {
      this.hubConnection.invoke('BroadcastMessage', mess)
        .catch(err => console.error(err));
    }
    return mess;
  }

  echo(): void {
    if (this.hubConnection) {
      this.hubConnection.invoke('Echo')
        .catch(err => console.error(err));
    }
  }

  private createConnection(): void {
    const firebaseToken = this.authService.getFirebaseToken();
    const watcherToken = this.authService.getWatcherToken();
    const connPath = `${environment.server_url}/dashboards?Authorization=${firebaseToken}&WatcherAuthorization=${watcherToken}`;

    this.hubConnection = new signalR.HubConnectionBuilder()
      .withUrl(connPath) // {accessTokenFactory: () => firebaseToken}
      .configureLogging(signalR.LogLevel.Information)
      .build();
  }

  private registerOnServerEvents(): void {

    this.hubConnection.on('InstanceDataTick', (info: PercentageInfo) => {
        this.infoSub.next(info);
      }
    );

    this.hubConnection.on('MarketTick', (marketStatus: MarketPriceDate) => {
        this.marketSub.next(marketStatus);
      }
    );

    this.hubConnection.on('CollectedPercentageInfoTick', (info: PercentageInfo) => {
        this.infoSub.next(info);
      }
    );

    this.hubConnection.on('Send', (data: any) => {
      console.log('Data received:' + data);
      this.sampleReceived.emit(data);
    });

    this.hubConnection.on('Send', (item: string) => {
      console.log(`Message from Service Bus: ${item}`);
    });

    this.hubConnection.on('BroadcastMessage', (message: string) => {
      console.log('Broadcasted Message: ' + message);
    });

    this.hubConnection.on('Echo', (data: string) => {
      console.log('Received echo data from the hub');
      console.log(data);
    });

    this.hubConnection.on('DataFeedTick', (sampleDto: SampleDto) => {
      console.log(`Received Data feed from the hub: ${JSON.stringify(sampleDto)}`);
    });

    this.hubConnection.on('AddSample', (sampleDto: SampleDto, secondParam: string, thirdParam: number) => {
      console.log(`secondParam: ${secondParam}, thirdParam: ${thirdParam}`);
      console.log('Created SampleDto: ' + JSON.stringify(sampleDto) + sampleDto);
      this.sampleReceived.emit(sampleDto);
    });

    // On Close open connection again
    this.hubConnection.onclose(function (error) {
      console.log('CONNECTION CLOSED!!!');
      console.error(error);
      this.startHubConnection();
    });
  }


  // Reconnect loop
  private startHubConnection(): void {
    console.log('Connecting to Hub!!!');
    this.hubConnection.start()
      .then(() => {
        console.log('CONNECTION STARTED!!!');
        this.connectionIsEstablished = true;
        this.connectionEstablished.emit(true);
      })
      .catch(function (err) {
        console.error(err);
        setTimeout(this.startHubConnection(), 3000);
      });
  }
}

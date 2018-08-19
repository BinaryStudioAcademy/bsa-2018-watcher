import { Component, OnInit, EventEmitter } from '@angular/core';
import { FormControl, FormBuilder } from '@angular/forms';
import { FeedbackService } from '../../core/services/feedback.service';
import { AuthService } from '../../core/services/auth.service';
import { ToastrService } from '../../core/services/toastr.service';

import { NotificationsService } from '../../core/services/notifications.service';
import { HubConnection } from '@aspnet/signalr';
import * as signalR from '@aspnet/signalr';
import { environment } from '../../../environments/environment';

import { User } from '../../shared/models/user.model';
import { Feedback } from '../../shared/models/feedback.model';
import { Response } from '../../shared/models/response.model';
import { LongAnswerType } from '../../shared/models/long-answer-type.enum';
import { ShortAnswerType } from '../../shared/models/short-answer-type.enum';
import { ResponseService } from '../../core/services/response.service';
import { ValueTransformer } from '@angular/compiler/src/util';
import { ForShow } from '../forShow.model';

@Component({
  selector: 'app-feedback-list',
  templateUrl: './feedback-list.component.html',
  styleUrls: ['./feedback-list.component.sass']
})

export class FeedbackListComponent implements OnInit {

  feedback: Feedback;
  feedbacks: Feedback[];
  user: User;
  response: Response;
  responses: Response[];
  lstFeedbacks: ForShow[];
  display: boolean;
  email: string;
  totalRecords: number;
  private hubConnection: HubConnection;
  public responseCreated = new EventEmitter<Response>();
  private hubName = 'responcesHub';

  constructor(
    private fb: FormBuilder,
    private authService: AuthService,
    private feedbackService: FeedbackService,
    private toastrService: ToastrService,
    private notificationsService: NotificationsService,
    private responseService: ResponseService) {

    this.lstFeedbacks = new Array<ForShow>();
    this.display = false;

    const firebaseToken = this.authService.getFirebaseToken();
    const watcherToken = this.authService.getWatcherToken();
    const connPath = `${environment.server_url}/${this.hubName}?Authorization=${firebaseToken}&WatcherAuthorization=${watcherToken}`;
    this.hubConnection = new signalR.HubConnectionBuilder().withUrl('connPath').configureLogging(signalR.LogLevel.Information).build();
  }

  responseForm = this.fb.group({
    text: new FormControl({ value: ' ', disabled: false })
  });

  ngOnInit() {
    this.user = this.authService.getCurrentUser();
    if (this.user == null) {
      return;
    }
    this.feedbackService.getAll().subscribe((value: Feedback[]) => {
      this.sortByDueDate(value);
      this.totalRecords = value.length;
      this.feedbacks = value;
      this.fillLstFeedbacks();
    });

    this.registerOnEvents();

    this.responseService.getAll().subscribe((value: Response[]) => this.responses = value);
  }

  private sortByDueDate(value): void {
    value.sort((a, b) => new Date(b.createdAt).getTime() - new Date(a.createdAt).getTime());
  }

  private fillLstFeedbacks(): void {
    this.feedbacks.forEach(el => this.lstFeedbacks.push({
      main: el,
      willuse: ShortAnswerType[el.willUse],
      info: LongAnswerType[el.informatively],
      quickness: LongAnswerType[el.quickness],
      friendliness: LongAnswerType[el.friendliness],
    }));
  }

  showPopup(feedback: Feedback) {
    this.responseForm.reset();
    this.display = true;
    this.feedback = feedback;
    this.email = feedback.user.email;
  }

  onCancel() {
    this.display = false;
    this.feedback = null;
  }

  onSubmit() {
    this.display = false;
    const text = this.responseForm.get('text').value;
    if (!text || text === ' ') {
      this.toastrService.warning('Field is empty.');
      return;
    }
    const newResponse: Response = {
      id: 0,
      createdAt: new Date(),
      user: this.user,
      feedback: this.feedback,
      text: text
    };
    this.responseService.create(newResponse).
      subscribe(
        value => {
          this.toastrService.success('Added new response');
          this.responseCreated.subscribe((Dto: Response) => console.log('response created'));
          // this.notificationsService.connectToSignalR();
          // this.notificationsService.send(this.feedback.id.toString(), 'The response to your feedback has been sent to your email.');
        },
        error => {
          this.toastrService.error(`Error ocured status: ${error}`);
        });
  }

  private registerOnEvents(): void {
    this.hubConnection.on('ResponseCreated', (Dto: Response, secondParam: string, thirdParam: number) => {
      console.log(`secondParam: ${secondParam}, thirdParam: ${thirdParam}`);
      console.log('Created Dto: ' + JSON.stringify(Dto) + Dto);
      this.responseCreated.emit(Dto);
    });
  }
}

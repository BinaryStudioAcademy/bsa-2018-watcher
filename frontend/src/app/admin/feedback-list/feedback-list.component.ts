import { Component, OnInit } from '@angular/core';
import { FeedbackService } from '../../core/services/feedback.service';
import { AuthService } from '../../core/services/auth.service';
import { ToastrService } from '../../core/services/toastr.service';
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
  constructor(
        private authService: AuthService,
        private feedbackService: FeedbackService,
        private toastrService: ToastrService,
        private responseService: ResponseService) {
    this.lstFeedbacks = new Array<ForShow>();
  }

  ngOnInit() {
    this.user = this.authService.getCurrentUser();
    if (this.user == null) {
      return;
    }
    this.feedbackService.getAll().subscribe((value: Feedback[]) => {
      this.feedbacks = value;
      this.fillDropdown();
    });

    this.responseService.getAll().subscribe((value: Response[]) => this.responses = value);
  }

  private fillDropdown(): void {
    this.feedbacks.forEach(el => this.lstFeedbacks.push({
      main: el,
      willuse: ShortAnswerType[el.willUse],
      info: LongAnswerType[el.informatively],
      quickness: LongAnswerType[el.quickness],
      friendliness: LongAnswerType[el.friendliness],
    }));
  }

  onSubmit(feedback: Feedback) {
    this.response.id = 0;
    this.response.createdAt = new Date(),
      this.response.user = this.user,
      this.response.feedback = feedback;
    this.responseService.create(this.response).
      subscribe(
        value => {
          this.toastrService.success('Added new response');
        },
        error => {
          this.toastrService.error(`Error ocured status: ${error}`);
        });
  }
}

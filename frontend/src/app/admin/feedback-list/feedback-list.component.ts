import { Component, OnInit } from '@angular/core';
import { FormControl, FormBuilder } from '@angular/forms';
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
  display: boolean;

  constructor(
    private fb: FormBuilder,
    private authService: AuthService,
    private feedbackService: FeedbackService,
    private toastrService: ToastrService,
    private responseService: ResponseService) {

    this.lstFeedbacks = new Array<ForShow>();
    this.display = false;
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
      this.feedbacks = value;
      this.fillLstFeedbacks();
    });

    this.responseService.getAll().subscribe((value: Response[]) => this.responses = value);
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
    this.display = true;
    this.feedback = feedback;
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
        },
        error => {
          this.toastrService.error(`Error ocured status: ${error}`);
        });
  }
}

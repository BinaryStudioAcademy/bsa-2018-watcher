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

  constructor(
    private authService: AuthService,
    private feedbackService: FeedbackService,
    private toastrService: ToastrService,
    private responseService: ResponseService
  ) { }

  ngOnInit() {
    this.user = this.authService.getCurrentUser();
    if (this.user == null) {
      return;
    }
    this.feedbackService.getAll().subscribe((value: Feedback[]) => this.feedbacks = value);
    this.responseService.getAll().subscribe((value: Response[]) => this.responses = value);
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

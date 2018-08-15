import { Component, OnInit } from '@angular/core';
import { FeedbackService } from '../../core/services/feedback.service';
import { AuthService } from '../../core/services/auth.service';
import { ToastrService } from '../../core/services/toastr.service';
import { User } from '../../shared/models/user.model';
import { Feedback } from '../../shared/models/feedback.model';
import { LongAnswerType } from '../../shared/models/long-answer-type.enum';
import { ShortAnswerType } from '../../shared/models/short-answer-type.enum';

@Component({
  selector: 'app-feedback-list',
  templateUrl: './feedback-list.component.html',
  styleUrls: ['./feedback-list.component.sass']
})
export class FeedbackListComponent implements OnInit {

  feedback: Feedback;
  feedbacks: Feedback[];
  user: User;

  constructor(
    private authService: AuthService,
    private feedbackService: FeedbackService,
    private toastrService: ToastrService,
  ) { }

  ngOnInit() {
    this.user = this.authService.getCurrentUser();
    if (this.user == null) {
      return;
    }
    this.feedbackService.getAll().subscribe((value: Feedback[]) => this.feedbacks = value);
  }

}

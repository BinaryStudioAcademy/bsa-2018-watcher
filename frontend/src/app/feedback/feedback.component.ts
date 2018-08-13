import { Component, OnInit } from '@angular/core';
import { FormControl, FormBuilder } from '@angular/forms';
import { FeedbackService } from '../core/services/feedback.service';
import { AuthService } from '../core/services/auth.service';
import { ToastrService } from '../core/services/toastr.service';
import { Feedback } from '../shared/models/feedback.model';

@Component({
  selector: 'app-feedback',
  templateUrl: './feedback.component.html',
  styleUrls: ['./feedback.component.sass'],
  providers: [
    // ToastrService
  ]
})
export class FeedbackComponent implements OnInit {

  feedback: Feedback;
  feedbacks: Feedback[];

  constructor(
    // private fb: FormBuilder,
    private authService: AuthService,
    private feedbackService: FeedbackService,
    private toastrService: ToastrService) { }

  // organizationForm = this.fb.group({
  //   suggestions: new FormControl({ value: '', disabled: false })
  // });

  ngOnInit() {
    const user = this.authService.getCurrentUser();
    this.feedback.user = user;
    if (user == null) {
      return;
    }
    this.feedbackService.getAll().subscribe((value: Feedback[]) => this.feedbacks = value);
  }

  onSubmit() {
    // const c = Date.UTC().toUTCString();
    // const now = new Date(c);
    // this.feedback.createdAt = Date.UTC(now.getUTCFullYear(), now.getUTCMonth(), now.getUTCDate(),
    //  now.getUTCHours(), now.getUTCMinutes(), now.getUTCSeconds());
    this.feedbackService.create(this.feedback);
    this.toastrService.confirm('Would you want to type one more feedback');
  }

}

import { Component, OnInit } from '@angular/core';
import { FormControl, FormBuilder } from '@angular/forms';
import { FeedbackService } from '../core/services/feedback.service';
import { AuthService } from '../core/services/auth.service';
import { ToastrService } from '../core/services/toastr.service';
import { Feedback } from '../shared/models/feedback.model';
import { UserService } from '../core/services/user.service';
import { User } from '../shared/models/user.model';
import { Router, RouterEvent, ActivatedRoute } from '@angular/router';

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
  user: User;

  constructor(
    private fb: FormBuilder,
    private authService: AuthService,
    private feedbackService: FeedbackService,
    private userService: UserService,
    private toastrService: ToastrService,
    private router: Router) { }

  feedbackForm = this.fb.group({
    suggestions: new FormControl({ value: ' ', disabled: false })
  });

  ngOnInit() {
    this.user = this.authService.getCurrentUser();
    if (this.user == null) {
      return;
    }
    this.feedbackService.getAll().subscribe((value: Feedback[]) => this.feedbacks = value);
  }

  async onSubmit() {
    const text =  this.feedbackForm.get('suggestions').value;
    if (!text || text === ' ') {
      this.toastrService.warning('All fields are empty.');
      return;
    }
    const newFeedback: Feedback = {
      id: 0,
      createdAt: new Date(),
      user: this.user,
      text: this.feedbackForm.get('suggestions').value,
      response: null
    };
    // console.log(newFeedback);
    this.feedbackService.create(newFeedback).
      subscribe(
        value => {
          this.toastrService.success('Added new feedback');
          if (!this.user.email) {
            this.toastrService.info('If you want to receive emails, fill out the email field in Settings.');
          }
        },
        error => {
          this.toastrService.error(`Error ocured status: ${error}`);
        });
    if (await this.toastrService.confirm('Would you want to enter one more feedback?')) {
      this.feedbackForm.reset();
    } else {
      this.router.navigate(['/user']);
    }
  }

}

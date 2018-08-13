import { Component, OnInit } from '@angular/core';
import { FormControl, FormBuilder } from '@angular/forms';
import { FeedbackService } from '../core/services/feedback.service';
import { AuthService } from '../core/services/auth.service';
import { ToastrService } from '../core/services/toastr.service';
import { Feedback } from '../shared/models/feedback.model';
import { UserService } from '../core/services/user.service';
import { User } from '../shared/models/user.model';

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
  // private suggestions: string;

  constructor(
    private fb: FormBuilder,
    private authService: AuthService,
    private feedbackService: FeedbackService,
    private userService: UserService,
    private toastrService: ToastrService) { }

  feedbackForm = this.fb.group({
   suggestions: new FormControl({ value: '' })
  });

  ngOnInit() {
    this.user = this.authService.getCurrentUser();
    if (this.user == null) {
      return;
    }
    this.feedbackService.getAll().subscribe((value: Feedback[]) => this.feedbacks = value);
  }

  onSubmit() {
    debugger;
    const newFeedback: Feedback = {
      id: 0,
      createdAt: new Date(),
      user: this.user,
      text: this.feedbackForm.get('suggestions').value,
      response: null
    };
    console.log(newFeedback);
    this.feedbackService.create(newFeedback).
      subscribe(
        value => {
          this.toastrService.success('Added new feedback');
        },
        error => {
          this.toastrService.success(`Error ocured status: ${error}`);
      });
      // subscribe((data: Feedback) => this.feedbacks.push(data));
    this.toastrService.confirm('Would you want to type one more feedback');
  }

}

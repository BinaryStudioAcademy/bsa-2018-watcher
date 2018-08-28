import { Component, OnInit } from '@angular/core';
import { FormControl, FormBuilder } from '@angular/forms';
import { FeedbackService } from '../core/services/feedback.service';
import { AuthService } from '../core/services/auth.service';
import { ToastrService } from '../core/services/toastr.service';
import { Feedback } from '../shared/models/feedback.model';
// import { UserService } from '../core/services/user.service';
import { User } from '../shared/models/user.model';
import { LongAnswerType } from '../shared/models/long-answer-type.enum';
import { ShortAnswerType } from '../shared/models/short-answer-type.enum';
import { Router, RouterEvent, ActivatedRoute } from '@angular/router';


@Component({
  selector: 'app-feedback',
  templateUrl: './feedback.component.html',
  styleUrls: ['./feedback.component.sass'],
  providers: [
  ]
})

export class FeedbackComponent implements OnInit {

  feedback: Feedback;
  // feedbacks: Feedback[];
  user: User;
  isSubmiting: Boolean = false;

  constructor(
    private fb: FormBuilder,
    private authService: AuthService,
    private feedbackService: FeedbackService,
    // private userService: UserService,
    private toastrService: ToastrService,
    private router: Router) { }

  feedbackForm = this.fb.group({
    suggestions: new FormControl({ value: ' ', disabled: false }),
    willUse: new FormControl({ value: ShortAnswerType[ShortAnswerType.Abstain], disabled: false }),
    informatively: new FormControl({ value: LongAnswerType[LongAnswerType.Abstain], disabled: false }),
    friendliness: new FormControl({ value: LongAnswerType[LongAnswerType.Abstain], disabled: false }),
    quickness: new FormControl({ value: LongAnswerType[LongAnswerType.Abstain], disabled: false })
  });

  restForm() {
    this.feedbackForm.reset({
      suggestions: { value: ' ', disabled: false },
      willUse: { value: ShortAnswerType[ShortAnswerType.Abstain], disabled: false },
      informatively: { value: LongAnswerType[LongAnswerType.Abstain], disabled: false },
      friendliness: { value: LongAnswerType[LongAnswerType.Abstain], disabled: false },
      quickness: { value: LongAnswerType[LongAnswerType.Abstain], disabled: false }
    });
  }

  ngOnInit() {
    this.user = this.authService.getCurrentUser();
    if (this.user == null) {
      return;
    }

    // this.feedbackService.getAll().subscribe((value: Feedback[]) => this.feedbacks = value);
  }

  async onSubmit() {
    this.isSubmiting = true;
    const text =  this.feedbackForm.get('suggestions').value;
    const willUse = this.feedbackForm.get('willUse').value;
    const informatively = this.feedbackForm.get('informatively').value;
    const friendliness = this.feedbackForm.get('friendliness').value;
    const quickness = this.feedbackForm.get('quickness').value;
    if (!willUse && !informatively && !friendliness && !quickness && (!text || text === ' ')) {
      this.toastrService.warning('All fields are empty.');
      this.isSubmiting = false;
      return;
    }
    const newFeedback: Feedback = {
      id: 0,
      createdAt: new Date(),
      user: this.user,
      text: text,
      willUse: willUse,
      informatively: informatively,
      friendliness: friendliness,
      quickness: quickness,
      response: null
    };
    console.log(newFeedback);
    this.feedbackService.create(newFeedback).
      subscribe(
        value => {
          this.toastrService.success('Added new feedback');
          if (!this.user.email) {
            this.toastrService.info('If you want to receive emails, fill out the email field in Settings.');
          }
          this.isSubmiting = false;
        },
        error => {
          this.toastrService.error(`Error ocured status: ${error.message}`);
          this.isSubmiting = false;
        });
    if (await this.toastrService.question('Would you want to enter one more feedback?')) {
      this.restForm();
    } else {
      this.router.navigate(['/user']);
    }
  }

}

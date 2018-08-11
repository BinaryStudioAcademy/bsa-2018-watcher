import { Component, OnInit } from '@angular/core';
import { FormControl, FormBuilder } from '@angular/forms';
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

  constructor(
    // private fb: FormBuilder,
    private authService: AuthService,
    private toastrService: ToastrService) { }

  // organizationForm = this.fb.group({
  //   suggestions: new FormControl({ value: '', disabled: false })
  // });


  ngOnInit() {
    // const user = this.authService.getCurrentUser();
    // if (user == null) {
    //  return;
    // }
  }

  onSubmit() {}

  confirm() { this.toastrService.confirm('Would you want to type'); }

}

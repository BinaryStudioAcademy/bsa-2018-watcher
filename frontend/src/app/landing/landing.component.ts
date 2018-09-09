import { Component, OnInit, OnDestroy } from '@angular/core';
import { FeedbackService } from '../core/services/feedback.service';
import { ToastrService } from '../core/services/toastr.service';
import { LongAnswerType } from '../shared/models/long-answer-type.enum';
import { ShortAnswerType } from '../shared/models/short-answer-type.enum';
import { Feedback } from '../shared/models/feedback.model';

@Component({
  selector: 'app-landing',
  templateUrl: './landing.component.html',
  styleUrls: ['./landing.component.sass',
  './landing.component.cards.sass',
  './landing.component.footer.sass',
  './landing.component.header.sass'],
})
export class LandingComponent implements OnInit, OnDestroy {
  isAbout: Boolean = false;
  name: string;
  email: string;
  text: string;

  constructor(private feedbackService: FeedbackService, private toastrService: ToastrService) {}

  onFeedback() {
    const newFeedback: Feedback = {
      id: 0,
      createdAt: new Date(),
      user: null,
      text: this.text,
      willUse: ShortAnswerType.Abstain,
      informatively: LongAnswerType.Abstain,
      friendliness: LongAnswerType.Abstain,
      quickness: LongAnswerType.Abstain,
      response: null
    };
    this.feedbackService.create(newFeedback).
    subscribe(
      value => {
        this.toastrService.success('Added new feedback');
        if (!this.email) {
          this.toastrService.info('If you want to receive emails, fill out the email field.');
        }
      },
      error => {
        this.toastrService.error(`Error ocured status: ${error.message}`);
      });
  }

  headerScroll(): any {
    const scrolled = window.pageYOffset || document.documentElement.scrollTop;
    if (scrolled < 100) {
      document.getElementById('header').style.background = 'rgba(0,0,0,0.2)';
    } else { document.getElementById('header').style.background = 'rgba(0,0,0,0.8)'; }}

  scrollTo(id: string): void {
    this.isAbout = false;
    const element = document.getElementById(id);
    element.scrollIntoView( {block: 'start', behavior: 'smooth'});
    const menu = document.getElementById('nav');
    if (menu.style.display === 'block') {
      this.show();
    }
  }
  show(): void {
    const menu = document.getElementById('nav');
    if (menu.style.visibility === 'visible') {
      menu.style.visibility = 'hidden'; } else { menu.style.visibility = 'visible'; }
  }

  resize(): void {
    if (window.innerWidth > 730) {document.getElementById('nav').style.visibility = 'visible'; }
  }
  ngOnInit() {
    window.addEventListener('resize', this.resize, true);
    window.addEventListener('scroll', this.headerScroll, true);
  }
  ngOnDestroy() {
    window.removeEventListener('scroll', this.headerScroll, true);
    window.removeEventListener('resize', this.resize, true);

}
}

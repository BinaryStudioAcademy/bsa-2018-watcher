import { Component, OnInit, OnDestroy } from '@angular/core';
import { FeedbackService } from '../core/services/feedback.service';
import { ToastrService } from '../core/services/toastr.service';
import { LongAnswerType } from '../shared/models/long-answer-type.enum';
import { ShortAnswerType } from '../shared/models/short-answer-type.enum';
import { Feedback } from '../shared/models/feedback.model';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-landing',
  templateUrl: './landing.component.html',
  styleUrls: ['./landing.component.sass',
    './landing.component.cards.sass'
  ],
})
export class LandingComponent implements OnInit, OnDestroy {

  isAbout: Boolean = false;
  name: string;
  email: string;
  text: string;

  constructor(
    private feedbackService: FeedbackService,
    private activatedRoute: ActivatedRoute,
    private toastrService: ToastrService,
    private router: Router) { }

  ngOnInit() {
    window.scrollTo(0, 0);
    window.addEventListener('resize', this.resize, true);
    window.addEventListener('scroll', this.headerScroll, true);

    this.activatedRoute.fragment.subscribe(fragment => {
      this.scrollTo(fragment);
    });
  }

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
      response: null,
      name: this.name,
      email: this.email
    };

    this.feedbackService.create(newFeedback).subscribe(value => {
      this.toastrService.success('Added new feedback');
    }, error => {
      this.toastrService.error(`Error ocured status: ${error.message}`);
    });

    this.name = '';
    this.email = '';
    this.text = '';
  }

  headerScroll(): any {
    const scrolled = window.pageYOffset || document.documentElement.scrollTop;
    document.getElementById('header').style.background = scrolled < 100 ? 'rgba(0,0,0,0.2)' : 'rgba(0,0,0,0.8)';
  }

  scrollTo(id: string): void {
    const element = document.getElementById(id);
    if (element) {
      element.scrollIntoView({
        block: 'start',
        behavior: 'smooth'
      });
    }
    const menu = document.getElementById('nav');
    if (menu.style.display === 'block') {
      this.show();
    }
  }

  show(): void {
    const menu = document.getElementById('nav');
    menu.style.visibility = menu.style.visibility === 'visible' ? 'hidden' : 'visible';
  }

  resize(): void {
    if (window.innerWidth > 730) {
      document.getElementById('nav').style.visibility = 'visible';
    }
  }

  ngOnDestroy() {
    window.removeEventListener('scroll', this.headerScroll, true);
    window.removeEventListener('resize', this.resize, true);
  }
}

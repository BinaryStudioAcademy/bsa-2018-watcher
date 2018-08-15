import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '../../../../node_modules/@angular/router';

@Component({
  selector: 'app-edit-instance',
  templateUrl: './edit-instance.component.html',
  styleUrls: ['./edit-instance.component.sass']
})
export class EditInstanceComponent implements OnInit {

  id: number;
  creation: boolean;

  constructor(private activateRoute: ActivatedRoute) { }

  ngOnInit() {
    const x = this.activateRoute.params.subscribe(params => {
      this.id = params['id'];
      if (this.id) {this.creation = false; } else {
        this.creation = true; }
      console.log(this.creation); } );
  }

}

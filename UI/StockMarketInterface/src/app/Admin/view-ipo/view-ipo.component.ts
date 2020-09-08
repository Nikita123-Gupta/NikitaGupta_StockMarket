import { Component, OnInit } from '@angular/core';
import { IpoDetails } from '../../Models/ipo-details';
import { Router } from '@angular/router';

@Component({
  selector: 'app-view-ipo',
  templateUrl: './view-ipo.component.html',
  styleUrls: ['./view-ipo.component.css']
})
export class ViewIPOComponent implements OnInit {
  list: IpoDetails[];
  constructor(private router: Router) {
    this.list = JSON.parse(localStorage.getItem("list"));
  }

  ngOnInit(): void {
  }
  Back() {
    this.router.navigateByUrl('admin-land-page');
  }
}

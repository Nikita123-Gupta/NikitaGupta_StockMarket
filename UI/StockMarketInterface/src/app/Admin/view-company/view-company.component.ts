import { Component, OnInit } from '@angular/core';
import { Company } from '../../Models/company';
import { Router } from '@angular/router';

@Component({
  selector: 'app-view-company',
  templateUrl: './view-company.component.html',
  styleUrls: ['./view-company.component.css']
})
export class ViewCompanyComponent implements OnInit {
  list: Company[];
  constructor(private router: Router) {
    this.list = JSON.parse(localStorage.getItem("list"));
    console.log(this.list);
  }

  ngOnInit(): void {
  }
  Back() {
    this.router.navigateByUrl('admin-land-page');
  }
}

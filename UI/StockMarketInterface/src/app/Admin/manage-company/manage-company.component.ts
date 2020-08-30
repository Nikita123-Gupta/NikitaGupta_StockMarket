import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
@Component({
  selector: 'app-manage-company',
  templateUrl: './manage-company.component.html',
  styleUrls: ['./manage-company.component.css']
})
export class ManageCompanyComponent implements OnInit {

  constructor(private router:Router) { }

  ngOnInit(): void {
  }
  ImportPage() {
    this.router.navigateByUrl('import');
  }
  ManageComp() {
    this.router.navigateByUrl('manage-company');
  }
  UpdateIPO() {
    this.router.navigateByUrl('update-ipo');
  }
}

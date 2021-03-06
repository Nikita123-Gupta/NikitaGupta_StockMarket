import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-admin-land-page',
  templateUrl: './admin-land-page.component.html',
  styleUrls: ['./admin-land-page.component.css']
})
export class AdminLandPageComponent implements OnInit {

  constructor(private router: Router) { }

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

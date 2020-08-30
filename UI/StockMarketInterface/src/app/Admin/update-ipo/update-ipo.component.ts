import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
@Component({
  selector: 'app-update-ipo',
  templateUrl: './update-ipo.component.html',
  styleUrls: ['./update-ipo.component.css']
})
export class UpdateIPOComponent implements OnInit {

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

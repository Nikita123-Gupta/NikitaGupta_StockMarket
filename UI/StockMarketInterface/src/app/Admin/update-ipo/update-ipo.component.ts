import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { IpoDetails } from '../../Models/ipo-details';
import { AdminService } from '../../Shared/admin.service';
@Component({
  selector: 'app-update-ipo',
  templateUrl: './update-ipo.component.html',
  styleUrls: ['./update-ipo.component.css']
})
export class UpdateIPOComponent implements OnInit {
  list: IpoDetails[] = [];
  id: number;
  code: string;
  stock: string;
  price: number;
  share: number;
  datetime: string;
  remarks: string;
  obj: IpoDetails;
  constructor(private service: AdminService, private router:Router) { }

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

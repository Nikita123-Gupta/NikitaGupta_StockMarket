import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Company } from '../../Models/company';
import { AdminService } from '../../Shared/admin.service';
@Component({
  selector: 'app-manage-company',
  templateUrl: './manage-company.component.html',
  styleUrls: ['./manage-company.component.css']
})
export class ManageCompanyComponent implements OnInit {
  list: Company[] = [];
  code: string;
  name: string;
  ceo: string;
  obj: Company;
  constructor(private service: AdminService, private router: Router) { }

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
  public Get() {
    this.service.GetAllCompany().subscribe(i => {
      this.list = i
      console.log(this.list)
    })
  }

  public Add() {
    
    this.obj = new Company();
    this.obj.CompanyCode = this.code;
    this.obj.CompanyName = this.name;
    this.obj.CEO = this.ceo;
    console.log(this.obj);
    this.service.AddCompany(this.obj).subscribe((response) => {
      console.log(response);
    }, (error) => {
      console.log(error)
      console.log(error.error.text)
    })
  }

  public Update() {
    this.obj = {
      CompanyCode: this.code,
      CompanyName: this.name,
      CEO: this.ceo
    };
    this.service.UpdateCompany(this.obj).subscribe(i => {
      console.log(i)
    },(error) => {
      console.log(error)
      console.log(error.error.text)
    })
  }

  public Delete() {
    this.service.DeleteCompany(this.code).subscribe(res => {
      console.log(res);
    }, (error) => {
      console.log(error)
      console.log(error.error.text)
    })
  }
}

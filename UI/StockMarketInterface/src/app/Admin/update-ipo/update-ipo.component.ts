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
  name: string;
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
  public Get() {
    this.service.GetAllIpo().subscribe(i => {
      this.list = i
      console.log(this.list);
      localStorage.setItem("list", JSON.stringify(this.list));
      this.router.navigateByUrl('view-ipo');
    }, (error) => {
      console.log(error)
      console.log(error.error.text)
    })
    
  }
  public Add() {

    this.obj = new IpoDetails();
    
    this.obj.CompanyName = this.name;
    this.obj.StockExchange = this.stock;
    this.obj.Price = this.price;
    this.obj.TotalShares = this.share;
    this.obj.DateTime = this.datetime;
    this.obj.Remarks = this.remarks;
    console.log(this.obj);
    this.service.AddIpo(this.obj).subscribe((response) => {
      console.log(response);
    }, (error) => {
      console.log(error)
      console.log(error.error.text)
    })
  }
  public Update() {
    this.obj = {
      Id: this.id,
      CompanyName: this.name,
      StockExchange: this.stock,
      Price: this.price,
      TotalShares: this.share,
      DateTime: this.datetime,
      Remarks: this.remarks
    };
    this.service.UpdateIpo(this.obj).subscribe(i => {
      console.log(i)
    }, (error) => {
      console.log(error)
      console.log(error.error.text)
    })
  }
  public Delete() {
    this.service.DeleteIpo(this.id).subscribe(res => {
      console.log(res);
    }, (error) => {
      console.log(error)
      console.log(error.error.text)
    })
  }

}

import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ImportService } from '../../Shared/import.service';

@Component({
  selector: 'app-import',
  templateUrl: './import.component.html',
  styleUrls: ['./import.component.css']
})
export class ImportComponent implements OnInit {
  path: string;
  constructor(private service:ImportService,private router:Router) { }

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
  public Export() {
    this.service.Export().subscribe(i => {
      console.log("Exported")
    }, (error) => {
      console.log(error)
      console.log(error.error.text)
    })
    alert("Expoted Data to Excel");
  }
  public Upload() {
    this.service.Upload(this.path).subscribe(res => {
      console.log("Imported");
    }, (error) => {
      console.log(error)
      console.log(error.error.text)
    })
    alert("Imported data");
  }
}

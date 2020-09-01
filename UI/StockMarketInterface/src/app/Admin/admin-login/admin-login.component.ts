import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-admin-login',
  templateUrl: './admin-login.component.html',
  styleUrls: ['./admin-login.component.css']
})
export class AdminLoginComponent implements OnInit {
  uname: string;
  password: string;
  constructor(private router:Router) { }

  ngOnInit(): void {
  }
  Validate() {
    if (this.uname == "Admin" && this.password == "password") {
      this.router.navigateByUrl('admin-land-page');
    }
    else {
      alert('Invalid Credentials');
    }
  }

}

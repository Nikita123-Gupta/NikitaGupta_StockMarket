import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from "rxjs";
import { Company } from '../Models/company';
import { IpoDetails } from '../Models/ipo-details';
@Injectable({
  providedIn: 'root'
})
export class AdminService {
  constructor(private http:HttpClient) { }
  path: string = "http://localhost:51789/Admin/";

  public GetAllCompany(): Observable<Company[]> {
    return this.http.get<Company[]>(this.path + "GetCompany")
  }

  public GetAllIpo(): Observable<IpoDetails[]> {
    return this.http.get<IpoDetails[]>(this.path + "GetIpo")
  }

  public AddCompany(item: Company): Observable<any> {
    console.log(item);
    return this.http.post<any>(this.path + 'AddCompany',item);
  }
  public UpdateCompany(item:Company): Observable<any> {
    console.log(item);
    return this.http.put<any>(this.path + 'EditCompany' , item);
  }
  public DeleteCompany(code: string): Observable<any> {
    console.log(code);
    return this.http.delete<any>(this.path + 'DeleteCompany/' + code);
  }
  public AddIpo(item: IpoDetails): Observable<any> {
    console.log(item);
    return this.http.post<any>(this.path + 'AddIpo', item);
  }
  public UpdateIpo(item: IpoDetails): Observable<any> {
    console.log(item);
    return this.http.put<any>(this.path + 'UpdateIpo', item);
  }
  public DeleteIpo(id: number): Observable<any> {
    console.log(id);
    return this.http.delete<any>(this.path + 'DeleteIpo/' + id);
  }
}

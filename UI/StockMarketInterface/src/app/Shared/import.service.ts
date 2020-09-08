import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from "rxjs";

@Injectable({
  providedIn: 'root'
})
export class ImportService {
 
  constructor(private http: HttpClient) { }
  path: string = "http://localhost:51789/Excel/";

  public Upload(path:string): Observable<any> {
    console.log(path);
    return this.http.get<any>(this.path + 'Import/' + path);
  }
  public Export(): Observable<any> {
    console.log("Export");
    return this.http.get<any>(this.path + 'Export');
  }
}

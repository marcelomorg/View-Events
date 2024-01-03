import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Event } from '../models/event';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class EventService {

  constructor(private http: HttpClient) { }

  private BaseUrlConn = "http://localhost:5277/Event";



  public clientGetAll():Observable<Event[]>{
    return this.http.get<Event[]>(this.BaseUrlConn);
  }

  public clientGetId(id:number): Observable<Event>{
    return this.http.get<Event>(this.BaseUrlConn + "/id/" + id);
  }
}

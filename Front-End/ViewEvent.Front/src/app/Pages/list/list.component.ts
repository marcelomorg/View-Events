import { Component } from '@angular/core';
import { PageChangedEvent } from 'ngx-bootstrap/pagination';
import { EventService } from '../../services/event.service';
import { Event } from '../../models/event';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrl: './list.component.scss'
})
export class ListComponent{ 

  eventDataHalf: Event[] = [];
  eventData: Event[] = [];
  showPagination = true;

  constructor(private eventService: EventService ){    
    this.getEvents();
    // this.getEventsId(1);
  }

  public getEvents(){
    this.eventService.clientGetAll().subscribe(
      response => {
        this.eventData = response;
        this.eventDataHalf = this.eventData.slice(0, this.itemsPerPage); //Data for table
      },
      error => console.log(error)      
    )
  }

  public getEventsId(id:number){
    this.eventService.clientGetId(id).subscribe(
      (response: Event) => {
        this.eventData[0] = response;
        this.eventDataHalf = this.eventData.slice(0, this.itemsPerPage); //Data for Table.
      },
      error => console.log(error)
    )
  }
 
  itemsPerPage = 3;
  public pageChanged(event: PageChangedEvent):void{
    const startItem = (event.page -1) * event.itemsPerPage;
    const endItem = event.page * event.itemsPerPage;
    this.eventDataHalf = this.eventData.slice(startItem, endItem);
  }
 
  public getInputNavEmit(obj:string):void {
    if(obj.length){
      this.eventDataHalf = this.eventData.filter((item: any)=> item.theme.toLowerCase().includes(obj.toLowerCase()));
      this.showPagination = false;
    }else{
      this.showPagination = true;
      this.eventDataHalf = this.eventData.slice(0, this.itemsPerPage);
    }

  }
}

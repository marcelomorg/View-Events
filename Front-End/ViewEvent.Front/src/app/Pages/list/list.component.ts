import { AfterViewChecked, AfterViewInit, Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { PageChangedEvent } from 'ngx-bootstrap/pagination';
import { EventService } from '../../services/event.service';
import { Event } from '../../models/event';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrl: './list.component.scss'
})
export class ListComponent implements OnInit, AfterViewChecked{ 

  eventDataHalf: Event[] = [];
  eventData: Event[] = [];
  showPagination = true;
  ShowSearch = true;
  css_levelOne_amount = "Amount of People"

  constructor(private eventService: EventService, private acivatedrouter: ActivatedRoute){
  }

  ngOnInit(): void {
    const ident = this.acivatedrouter.snapshot.paramMap.get('id');
    if( ident ){
      this.getEventsId(parseInt(ident));
      this.showPagination = false;
      this.ShowSearch = false;
    }else{
      this.getEvents();
    }
  }
  
  ngAfterViewChecked(): void {
    this.getAmountPeople();
  }

  getAmountPeople(){
    if(screen.width < 800){
      this.css_levelOne_amount = "Amount";
    }
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

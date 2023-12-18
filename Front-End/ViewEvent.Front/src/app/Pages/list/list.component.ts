import { Component } from '@angular/core';
import { PageChangedEvent } from 'ngx-bootstrap/pagination';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrl: './list.component.scss'
})
export class ListComponent{

  itemsPerPage = 4;
  mockdateReturn: any[] = [];
  mockdate = 
  [
    {id:'1', local:'City1', eventdate:'00/00/00', theme:'aEvent1', peopleamount:'100', imgurl:'https://t4.ftcdn.net/jpg/03/83/26/13/360_F_383261384_86BWn0mijMqqo6svwYvLEDzcq9qe8w47.jpg'},
    {id:'2', local:'City2', eventdate:'00/00/00', theme:'bEvent2', peopleamount:'200', imgurl:'https://t4.ftcdn.net/jpg/03/83/26/13/360_F_383261384_86BWn0mijMqqo6svwYvLEDzcq9qe8w47.jpg'},
    {id:'3', local:'City3', eventdate:'00/00/00', theme:'cEvent3', peopleamount:'300', imgurl:'https://t4.ftcdn.net/jpg/03/83/26/13/360_F_383261384_86BWn0mijMqqo6svwYvLEDzcq9qe8w47.jpg'},
    {id:'4', local:'City4', eventdate:'00/00/00', theme:'dEvent4', peopleamount:'400', imgurl:'https://t4.ftcdn.net/jpg/03/83/26/13/360_F_383261384_86BWn0mijMqqo6svwYvLEDzcq9qe8w47.jpg'},
    {id:'5', local:'City5', eventdate:'00/00/00', theme:'eEvent5', peopleamount:'500', imgurl:'https://t4.ftcdn.net/jpg/03/83/26/13/360_F_383261384_86BWn0mijMqqo6svwYvLEDzcq9qe8w47.jpg'},
    {id:'6', local:'City1', eventdate:'00/00/00', theme:'vEvent1', peopleamount:'100', imgurl:'https://t4.ftcdn.net/jpg/03/83/26/13/360_F_383261384_86BWn0mijMqqo6svwYvLEDzcq9qe8w47.jpg'},
    {id:'7', local:'City2', eventdate:'00/00/00', theme:'xEvent2', peopleamount:'200', imgurl:'https://t4.ftcdn.net/jpg/03/83/26/13/360_F_383261384_86BWn0mijMqqo6svwYvLEDzcq9qe8w47.jpg'},
    {id:'8', local:'City3', eventdate:'00/00/00', theme:'dEvent3', peopleamount:'300', imgurl:'https://t4.ftcdn.net/jpg/03/83/26/13/360_F_383261384_86BWn0mijMqqo6svwYvLEDzcq9qe8w47.jpg'},
    {id:'9', local:'City4', eventdate:'00/00/00', theme:'gEvent4', peopleamount:'400', imgurl:'https://t4.ftcdn.net/jpg/03/83/26/13/360_F_383261384_86BWn0mijMqqo6svwYvLEDzcq9qe8w47.jpg'},
    {id:'10', local:'City5', eventdate:'00/00/00', theme:'mEvent5', peopleamount:'500', imgurl:'https://t4.ftcdn.net/jpg/03/83/26/13/360_F_383261384_86BWn0mijMqqo6svwYvLEDzcq9qe8w47.jpg'},
    {id:'11', local:'City1', eventdate:'00/00/00', theme:'uEvent1', peopleamount:'100', imgurl:'https://t4.ftcdn.net/jpg/03/83/26/13/360_F_383261384_86BWn0mijMqqo6svwYvLEDzcq9qe8w47.jpg'},
    {id:'12', local:'City2', eventdate:'00/00/00', theme:'oEvent2', peopleamount:'200', imgurl:'https://t4.ftcdn.net/jpg/03/83/26/13/360_F_383261384_86BWn0mijMqqo6svwYvLEDzcq9qe8w47.jpg'},
    {id:'13', local:'City3', eventdate:'00/00/00', theme:'eEvent3', peopleamount:'300', imgurl:'https://t4.ftcdn.net/jpg/03/83/26/13/360_F_383261384_86BWn0mijMqqo6svwYvLEDzcq9qe8w47.jpg'},
    {id:'14', local:'City4', eventdate:'00/00/00', theme:'aEvent4', peopleamount:'400', imgurl:'https://t4.ftcdn.net/jpg/03/83/26/13/360_F_383261384_86BWn0mijMqqo6svwYvLEDzcq9qe8w47.jpg'},
    {id:'15', local:'City5', eventdate:'00/00/00', theme:'fEvent5', peopleamount:'500', imgurl:'https://t4.ftcdn.net/jpg/03/83/26/13/360_F_383261384_86BWn0mijMqqo6svwYvLEDzcq9qe8w47.jpg'},
    {id:'16', local:'City1', eventdate:'00/00/00', theme:'hhEvent1', peopleamount:'100', imgurl:'https://t4.ftcdn.net/jpg/03/83/26/13/360_F_383261384_86BWn0mijMqqo6svwYvLEDzcq9qe8w47.jpg'},
    {id:'17', local:'City2', eventdate:'00/00/00', theme:'rEvent2', peopleamount:'200', imgurl:'https://t4.ftcdn.net/jpg/03/83/26/13/360_F_383261384_86BWn0mijMqqo6svwYvLEDzcq9qe8w47.jpg'},
    {id:'18', local:'City3', eventdate:'00/00/00', theme:'uEvent3', peopleamount:'300', imgurl:'https://t4.ftcdn.net/jpg/03/83/26/13/360_F_383261384_86BWn0mijMqqo6svwYvLEDzcq9qe8w47.jpg'},
    {id:'19', local:'City4', eventdate:'00/00/00', theme:'lEvent4', peopleamount:'400', imgurl:'https://t4.ftcdn.net/jpg/03/83/26/13/360_F_383261384_86BWn0mijMqqo6svwYvLEDzcq9qe8w47.jpg'},
    {id:'20', local:'City5', eventdate:'00/00/00', theme:'aEvent5', peopleamount:'500', imgurl:'https://t4.ftcdn.net/jpg/03/83/26/13/360_F_383261384_86BWn0mijMqqo6svwYvLEDzcq9qe8w47.jpg'},
  ]

  constructor(){
    this.mockdateReturn = this.mockdate.slice(0, this.itemsPerPage);
  }
 
  
  public pageChanged(event: PageChangedEvent):void{
    const startItem = (event.page -1) * event.itemsPerPage;
    const endItem = event.page * event.itemsPerPage;
    this.mockdateReturn = this.mockdate.slice(startItem, endItem);
  }
 
  public getInputNavEmit(obj:string):void {
    this.mockdateReturn = this.mockdate.filter(item => item.theme.toLowerCase().includes(obj));
  }

}

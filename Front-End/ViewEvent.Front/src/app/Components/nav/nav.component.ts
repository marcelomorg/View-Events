import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrl: './nav.component.scss'
})
export class NavComponent {
  @Input() showSearchInput:boolean = false;
  isCollapsed = true;

 inputNav = "";
 @Output() inputNavEmit = new EventEmitter();
 public  lauch(){
  this.inputNavEmit.emit(this.inputNav);
 }
  
}

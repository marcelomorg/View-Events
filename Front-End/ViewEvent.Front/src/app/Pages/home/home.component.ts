import { Component, Output } from '@angular/core';
import { CarouselConfig } from 'ngx-bootstrap/carousel'

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrl: './home.component.scss',
  providers: [
    { provide: CarouselConfig, useValue: { interval: 3000, noPause: true, showIndicators: true } }
  ]
})
export class HomeComponent {
  title = "Home"
}

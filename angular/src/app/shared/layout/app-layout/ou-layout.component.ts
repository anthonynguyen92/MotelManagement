import { AfterContentInit, AfterViewInit, Component, Injector, OnInit } from '@angular/core';
import { AppBaseComponent } from '../../app.base.component';
declare var $;

@Component({
  selector: 'ou-layout',
  templateUrl: 'ou-layout.component.html',
  styleUrls: ['ou-layout.component.css']
})

export class OuLayoutComponent implements OnInit, AfterContentInit, AfterViewInit {
  constructor() { }

  ngOnInit() {
  }
  ngAfterViewInit(): void {
  }
  ngAfterContentInit() {
  }

  onResize(event) {
  }
}

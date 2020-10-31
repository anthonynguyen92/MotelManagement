import { LazyLoadService, AddReplaceableComponent } from '@abp/ng.core';
import { eThemeBasicComponents } from '@abp/ng.theme.basic';
import { Component, OnInit } from '@angular/core';
import { Store } from '@ngxs/store';
import { LoginComponent } from './login/login.component';
import { eAccountComponents } from '@abp/ng.account';
import { OuLayoutComponent } from './shared/layout/app-layout/ou-layout.component';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
})
export class AppComponent implements OnInit {
  constructor(private lazyLoadService: LazyLoadService, private store: Store) { }

  ngOnInit() {
    this.store.dispatch(
      new AddReplaceableComponent({
        component: OuLayoutComponent,
        key: eThemeBasicComponents.ApplicationLayout,
      })
    );

    this.store.dispatch(
      new AddReplaceableComponent({
        component: LoginComponent,
        key: eAccountComponents.Login
      })
    );
  }
}


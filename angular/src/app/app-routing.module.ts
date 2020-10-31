import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { OuLayoutComponent } from './shared/layout/app-layout/ou-layout.component';
import { AuthGuard } from '@abp/ng.core';

const routes: Routes = [
  {
    component: OuLayoutComponent,
    path: '',
    canActivate: [AuthGuard],
    children: [
      {
        path: 'home',
        loadChildren: () => import('./home/home.module').then(m => m.HomeModule),
      },
      {
        path: '',
        redirectTo: '/home',
        pathMatch: 'full'
      }
    ]
  },
  {
    path: 'account',
    loadChildren: () => import('@abp/ng.account')
      .then(m => m.AccountModule.forLazy({ redirectUrl: '/' })),
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule { }

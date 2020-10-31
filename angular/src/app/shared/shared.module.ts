import { NgbDropdownModule } from '@ng-bootstrap/ng-bootstrap';
import { NgModule } from '@angular/core';
import { NgxValidateCoreModule } from '@ngx-validate/core';
import { CoreModule } from '@abp/ng.core';
import { MatCardModule } from '@angular/material/card';
import { MatButtonModule } from '@angular/material/button';
import { MatMenuModule } from '@angular/material/menu';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatIconModule } from '@angular/material/icon';
import { DataTablesModule } from 'angular-datatables';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatSliderModule } from '@angular/material/slider';
import { MatCheckboxModule } from '@angular/material/checkbox';
import { MatExpansionModule } from '@angular/material/expansion';
import { LocalizePipe } from './pipes/localize.pipe';
import { MatSelectModule } from '@angular/material/select';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatRadioModule } from '@angular/material/radio';
import { MatTreeModule } from '@angular/material/tree';
import { MatNativeDateModule, MAT_DATE_FORMATS, DateAdapter, MAT_DATE_LOCALE } from '@angular/material/core';
import { MomentDateAdapter, MAT_MOMENT_DATE_ADAPTER_OPTIONS } from '@angular/material-moment-adapter';
import { QuillModule } from 'ngx-quill';
import { MatSlideToggleModule } from '@angular/material/slide-toggle';
import { MatDividerModule } from '@angular/material/divider';
import { MatListModule } from '@angular/material/list';
import { CommonModule } from '@angular/common';
import { MatProgressBarModule } from '@angular/material/progress-bar';
import { OuLayoutComponent } from './layout/app-layout/ou-layout.component';
import { OuAccountLayoutComponent } from './layout/account/account-layout-component';
@NgModule({
  imports: [
    CommonModule,
    CoreModule,
    NgbDropdownModule,
    NgxValidateCoreModule,
    MatButtonModule,
    MatMenuModule,
    MatToolbarModule,
    MatIconModule,
    MatCardModule,
    DataTablesModule,
    MatInputModule,
    MatFormFieldModule,
    MatSliderModule,
    MatCheckboxModule,
    MatExpansionModule,
    MatSelectModule,
    MatDatepickerModule,
    MatRadioModule,
    MatNativeDateModule,
    MatSlideToggleModule,
    MatTreeModule,
    MatDividerModule,
    MatListModule,
    QuillModule.forRoot(),
    MatProgressBarModule
  ],
  declarations: [
    LocalizePipe,
    OuLayoutComponent,
    OuAccountLayoutComponent,
  ],
  exports: [
    CommonModule,
    CoreModule,
    NgbDropdownModule,
    NgxValidateCoreModule,
    MatButtonModule,
    MatMenuModule,
    MatToolbarModule,
    MatIconModule,
    MatCardModule,
    DataTablesModule,
    MatInputModule,
    MatFormFieldModule,
    MatSliderModule,
    MatCheckboxModule,
    MatExpansionModule,
    MatSelectModule,
    MatDatepickerModule,
    MatRadioModule,
    MatNativeDateModule,
    MatSlideToggleModule,
    MatTreeModule,
    MatDividerModule,
    MatListModule,
    QuillModule,
    MatProgressBarModule,
    OuLayoutComponent,
    OuAccountLayoutComponent,
  ],
  providers: [
    {
      provide: DateAdapter,
      useClass: MomentDateAdapter,
      deps: [MAT_DATE_LOCALE, MAT_MOMENT_DATE_ADAPTER_OPTIONS]
    },
    {
      provide: MAT_DATE_FORMATS,
      useValue: {
        parse: {
          dateInput: ['DD/MM/YYYY'],
        },
        display: {
          dateInput: 'DD/MM/YYYY',
          monthYearLabel: 'MMM YYYY',
          dateA11yLabel: 'DD/MM/YYYY',
          monthYearA11yLabel: 'MMMM YYYY',
        },
      },
    },
  ],
  entryComponents: [
  ]
})
export class SharedModule { }

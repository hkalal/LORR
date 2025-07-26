
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LrrFormComponent } from './components/lrr-form/lrr-form.component';
import { RrChecklistComponent } from './components/rr-checklist/rr-checklist.component';

@NgModule({
  declarations: [
    AppComponent,
    LrrFormComponent,
    RrChecklistComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

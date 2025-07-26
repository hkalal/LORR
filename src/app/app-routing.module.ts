
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LrrFormComponent } from './components/lrr-form/lrr-form.component';
import { RrChecklistComponent } from './components/rr-checklist/rr-checklist.component';

const routes: Routes = [
  { path: '', component: LrrFormComponent },
  { path: 'lrr-form', component: LrrFormComponent },
  { path: 'rr-checklist', component: RrChecklistComponent },
  { path: '**', redirectTo: '' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }


import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { LrrForm } from '../models/lrr-form.model';
import { RrChecklist } from '../models/rr-checklist.model';

@Injectable({
  providedIn: 'root'
})
export class LrrService {
  private apiUrl = '/api';

  constructor(private http: HttpClient) { }

  // LRR Form methods
  submitLrrForm(form: LrrForm): Observable<any> {
    return this.http.post(`${this.apiUrl}/lrr-forms`, form);
  }

  getLrrForms(): Observable<LrrForm[]> {
    return this.http.get<LrrForm[]>(`${this.apiUrl}/lrr-forms`);
  }

  getLrrForm(id: number): Observable<LrrForm> {
    return this.http.get<LrrForm>(`${this.apiUrl}/lrr-forms/${id}`);
  }

  updateLrrForm(id: number, form: LrrForm): Observable<any> {
    return this.http.put(`${this.apiUrl}/lrr-forms/${id}`, form);
  }

  deleteLrrForm(id: number): Observable<any> {
    return this.http.delete(`${this.apiUrl}/lrr-forms/${id}`);
  }

  // RR Checklist methods
  submitRrChecklist(checklist: RrChecklist): Observable<any> {
    return this.http.post(`${this.apiUrl}/rr-checklists`, checklist);
  }

  getRrChecklists(): Observable<RrChecklist[]> {
    return this.http.get<RrChecklist[]>(`${this.apiUrl}/rr-checklists`);
  }

  getRrChecklist(id: number): Observable<RrChecklist> {
    return this.http.get<RrChecklist>(`${this.apiUrl}/rr-checklists/${id}`);
  }

  updateRrChecklist(id: number, checklist: RrChecklist): Observable<any> {
    return this.http.put(`${this.apiUrl}/rr-checklists/${id}`, checklist);
  }

  deleteRrChecklist(id: number): Observable<any> {
    return this.http.delete(`${this.apiUrl}/rr-checklists/${id}`);
  }
}

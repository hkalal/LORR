
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { LrrService } from '../../services/lrr.service';
import { RrChecklist } from '../../models/rr-checklist.model';

@Component({
  selector: 'app-rr-checklist',
  templateUrl: './rr-checklist.component.html',
  styleUrls: ['./rr-checklist.component.css']
})
export class RrChecklistComponent implements OnInit {
  rrForm: FormGroup;
  checklists: RrChecklist[] = [];

  constructor(
    private fb: FormBuilder,
    private lrrService: LrrService
  ) {
    this.rrForm = this.createForm();
  }

  ngOnInit(): void {
    this.loadChecklists();
  }

  createForm(): FormGroup {
    return this.fb.group({
      criteria1: ['', Validators.required],
      criteria2: ['', Validators.required],
      criteria3: ['', Validators.required],
      description: [''],
      priority: [''],
      status: [''],
      createdDate: [new Date().toISOString().split('T')[0]],
      updatedDate: [new Date().toISOString().split('T')[0]]
    });
  }

  loadChecklists(): void {
    this.lrrService.getRrChecklists().subscribe({
      next: (data) => {
        this.checklists = data;
      },
      error: (error) => {
        console.error('Error loading checklists:', error);
      }
    });
  }

  onSubmit(): void {
    if (this.rrForm.valid) {
      const formData: RrChecklist = this.rrForm.value;
      this.lrrService.submitRrChecklist(formData).subscribe({
        next: (response) => {
          console.log('Checklist submitted successfully:', response);
          alert('RR Checklist submitted successfully!');
          this.rrForm.reset();
          this.loadChecklists();
        },
        error: (error) => {
          console.error('Error submitting checklist:', error);
          alert('Error submitting checklist. Please try again.');
        }
      });
    } else {
      alert('Please fill in all required fields.');
    }
  }

  onReset(): void {
    this.rrForm.reset();
  }

  deleteChecklist(id: number): void {
    if (confirm('Are you sure you want to delete this checklist?')) {
      this.lrrService.deleteRrChecklist(id).subscribe({
        next: () => {
          alert('Checklist deleted successfully!');
          this.loadChecklists();
        },
        error: (error) => {
          console.error('Error deleting checklist:', error);
          alert('Error deleting checklist.');
        }
      });
    }
  }
}

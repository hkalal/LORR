
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { LrrService } from '../../services/lrr.service';
import { LrrForm } from '../../models/lrr-form.model';

@Component({
  selector: 'app-lrr-form',
  templateUrl: './lrr-form.component.html',
  styleUrls: ['./lrr-form.component.css']
})
export class LrrFormComponent implements OnInit {
  lrrForm: FormGroup;

  constructor(
    private fb: FormBuilder,
    private lrrService: LrrService
  ) {
    this.lrrForm = this.createForm();
  }

  ngOnInit(): void {}

  createForm(): FormGroup {
    return this.fb.group({
      // General & Project Info
      sfdcRef: [''],
      dateCreated: [''],
      securityLevel: [''],
      projectNo: [''],
      solution: [''],
      creatorName: ['', Validators.required],
      docStatus: [''],
      projectStatus: [''],

      // Project & Tender Details
      projectName: ['', Validators.required],
      customerName: ['', Validators.required],
      customerCountry: [''],
      endUserName: [''],
      endUserCountry: [''],
      tenderResponsible: [''],
      tenderUnit: [''],
      mainScope: [''],
      estimatedBid: [0],
      tenderDue: [''],
      awardDate: [''],
      salesManager: [''],
      projectManager: [''],
      tpmStatus: [''],

      // LRR Questionnaire
      q1: [''],
      q2: [''],
      q3: [''],
      q4: [''],
      q5: [''],
      q6: [''],
      q7: [''],
      q8: [''],
      q9: [''],

      // Financial & Contract Terms
      paymentTerms: [''],
      warrantyMonths: [0],
      warrantyClause: [''],
      scopeDetail: [''],
      financingStatus: [''],
      creditAssessment: [''],
      ldApplicable: [false],
      ldCapping: [''],
      ldClause: [''],

      // Risk Assessment & Mitigation
      identifiedRisk: [''],
      mitigationPlan: [''],

      // Delivery & Tax
      deliveryIncoterms: [''],
      taxExposure: [''],

      // Additional & Attachments
      comments: [''],
      confirmation: [false],

      // Project Financials
      pfBidValue: [0],
      pfGrossMargin: [0],
      pfNetMargin: [0],
      pfWarrantyProv: [0],
      pfInflation: [0],
      pfContingencies: [0],
      pfRiskProv: [0],
      pfTotalProv: [0],
      pfMatCost: [0],
      pfDeltaRR: [''],
      pfApprovalComments: [''],
      pptOutput: [false]
    });
  }

  onSubmit(): void {
    if (this.lrrForm.valid) {
      const formData: LrrForm = this.lrrForm.value;
      this.lrrService.submitLrrForm(formData).subscribe({
        next: (response) => {
          console.log('Form submitted successfully:', response);
          alert('LRR Form submitted successfully!');
          this.lrrForm.reset();
        },
        error: (error) => {
          console.error('Error submitting form:', error);
          alert('Error submitting form. Please try again.');
        }
      });
    } else {
      alert('Please fill in all required fields.');
    }
  }

  onReset(): void {
    this.lrrForm.reset();
  }
}

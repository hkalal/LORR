
export interface LrrForm {
  // General & Project Info
  sfdcRef: string;
  dateCreated: string;
  securityLevel: string;
  projectNo: string;
  solution: string;
  creatorName: string;
  docStatus: string;
  projectStatus: string;

  // Project & Tender Details
  projectName: string;
  customerName: string;
  customerCountry: string;
  endUserName: string;
  endUserCountry: string;
  tenderResponsible: string;
  tenderUnit: string;
  mainScope: string;
  estimatedBid: number;
  tenderDue: string;
  awardDate: string;
  salesManager: string;
  projectManager: string;
  tpmStatus: string;

  // LRR Questionnaire
  q1: string;
  q2: string;
  q3: string;
  q4: string;
  q5: string;
  q6: string;
  q7: string;
  q8: string;
  q9: string;

  // Financial & Contract Terms
  paymentTerms: string;
  warrantyMonths: number;
  warrantyClause: string;
  scopeDetail: string;
  financingStatus: string;
  creditAssessment: string;
  ldApplicable: boolean;
  ldCapping: string;
  ldClause: string;

  // Risk Assessment & Mitigation
  identifiedRisk: string;
  mitigationPlan: string;

  // Delivery & Tax
  deliveryIncoterms: string;
  taxExposure: string;

  // Additional & Attachments
  comments: string;
  confirmation: boolean;

  // Project Financials
  pfBidValue: number;
  pfGrossMargin: number;
  pfNetMargin: number;
  pfWarrantyProv: number;
  pfInflation: number;
  pfContingencies: number;
  pfRiskProv: number;
  pfTotalProv: number;
  pfMatCost: number;
  pfDeltaRR: string;
  pfApprovalComments: string;
  pptOutput: boolean;
}

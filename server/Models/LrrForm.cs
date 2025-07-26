
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LrrApp.Models
{
    public class LrrForm
    {
        [Key]
        public int Id { get; set; }

        // General & Project Info
        public string? SfdcRef { get; set; }
        public DateTime? DateCreated { get; set; }
        public string? SecurityLevel { get; set; }
        public string? ProjectNo { get; set; }
        public string? Solution { get; set; }
        [Required]
        public string CreatorName { get; set; } = string.Empty;
        public string? DocStatus { get; set; }
        public string? ProjectStatus { get; set; }

        // Project & Tender Details
        [Required]
        public string ProjectName { get; set; } = string.Empty;
        [Required]
        public string CustomerName { get; set; } = string.Empty;
        public string? CustomerCountry { get; set; }
        public string? EndUserName { get; set; }
        public string? EndUserCountry { get; set; }
        public string? TenderResponsible { get; set; }
        public string? TenderUnit { get; set; }
        public string? MainScope { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? EstimatedBid { get; set; }
        public DateTime? TenderDue { get; set; }
        public DateTime? AwardDate { get; set; }
        public string? SalesManager { get; set; }
        public string? ProjectManager { get; set; }
        public string? TpmStatus { get; set; }

        // LRR Questionnaire
        public string? Q1 { get; set; }
        public string? Q2 { get; set; }
        public string? Q3 { get; set; }
        public string? Q4 { get; set; }
        public string? Q5 { get; set; }
        public string? Q6 { get; set; }
        public string? Q7 { get; set; }
        public string? Q8 { get; set; }
        public string? Q9 { get; set; }

        // Financial & Contract Terms
        public string? PaymentTerms { get; set; }
        public int? WarrantyMonths { get; set; }
        public string? WarrantyClause { get; set; }
        public string? ScopeDetail { get; set; }
        public string? FinancingStatus { get; set; }
        public string? CreditAssessment { get; set; }
        public bool LdApplicable { get; set; }
        public string? LdCapping { get; set; }
        public string? LdClause { get; set; }

        // Risk Assessment & Mitigation
        public string? IdentifiedRisk { get; set; }
        public string? MitigationPlan { get; set; }

        // Delivery & Tax
        public string? DeliveryIncoterms { get; set; }
        public string? TaxExposure { get; set; }

        // Additional & Attachments
        public string? Comments { get; set; }
        public bool Confirmation { get; set; }

        // Project Financials
        [Column(TypeName = "decimal(18,2)")]
        public decimal? PfBidValue { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? PfGrossMargin { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? PfNetMargin { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? PfWarrantyProv { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? PfInflation { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? PfContingencies { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? PfRiskProv { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? PfTotalProv { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? PfMatCost { get; set; }
        public string? PfDeltaRR { get; set; }
        public string? PfApprovalComments { get; set; }
        public bool PptOutput { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}

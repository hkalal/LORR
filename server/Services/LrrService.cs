
using Microsoft.EntityFrameworkCore;
using LrrApp.Data;
using LrrApp.Models;

namespace LrrApp.Services
{
    public class LrrService : ILrrService
    {
        private readonly LrrDbContext _context;

        public LrrService(LrrDbContext context)
        {
            _context = context;
        }

        // LrrForm methods
        public async Task<IEnumerable<LrrForm>> GetAllLrrFormsAsync()
        {
            return await _context.LrrForms.ToListAsync();
        }

        public async Task<LrrForm?> GetLrrFormByIdAsync(int id)
        {
            return await _context.LrrForms.FindAsync(id);
        }

        public async Task<LrrForm> CreateLrrFormAsync(LrrForm lrrForm)
        {
            lrrForm.CreatedAt = DateTime.UtcNow;
            lrrForm.UpdatedAt = DateTime.UtcNow;
            
            _context.LrrForms.Add(lrrForm);
            await _context.SaveChangesAsync();
            return lrrForm;
        }

        public async Task<LrrForm?> UpdateLrrFormAsync(int id, LrrForm lrrForm)
        {
            var existingForm = await _context.LrrForms.FindAsync(id);
            if (existingForm == null)
                return null;

            // Update properties
            existingForm.SfdcRef = lrrForm.SfdcRef;
            existingForm.DateCreated = lrrForm.DateCreated;
            existingForm.SecurityLevel = lrrForm.SecurityLevel;
            existingForm.ProjectNo = lrrForm.ProjectNo;
            existingForm.Solution = lrrForm.Solution;
            existingForm.CreatorName = lrrForm.CreatorName;
            existingForm.DocStatus = lrrForm.DocStatus;
            existingForm.ProjectStatus = lrrForm.ProjectStatus;
            existingForm.ProjectName = lrrForm.ProjectName;
            existingForm.CustomerName = lrrForm.CustomerName;
            existingForm.CustomerCountry = lrrForm.CustomerCountry;
            existingForm.EndUserName = lrrForm.EndUserName;
            existingForm.EndUserCountry = lrrForm.EndUserCountry;
            existingForm.TenderResponsible = lrrForm.TenderResponsible;
            existingForm.TenderUnit = lrrForm.TenderUnit;
            existingForm.MainScope = lrrForm.MainScope;
            existingForm.EstimatedBid = lrrForm.EstimatedBid;
            existingForm.TenderDue = lrrForm.TenderDue;
            existingForm.AwardDate = lrrForm.AwardDate;
            existingForm.SalesManager = lrrForm.SalesManager;
            existingForm.ProjectManager = lrrForm.ProjectManager;
            existingForm.TpmStatus = lrrForm.TpmStatus;
            existingForm.Q1 = lrrForm.Q1;
            existingForm.Q2 = lrrForm.Q2;
            existingForm.Q3 = lrrForm.Q3;
            existingForm.Q4 = lrrForm.Q4;
            existingForm.Q5 = lrrForm.Q5;
            existingForm.Q6 = lrrForm.Q6;
            existingForm.Q7 = lrrForm.Q7;
            existingForm.Q8 = lrrForm.Q8;
            existingForm.Q9 = lrrForm.Q9;
            existingForm.PaymentTerms = lrrForm.PaymentTerms;
            existingForm.WarrantyMonths = lrrForm.WarrantyMonths;
            existingForm.WarrantyClause = lrrForm.WarrantyClause;
            existingForm.ScopeDetail = lrrForm.ScopeDetail;
            existingForm.FinancingStatus = lrrForm.FinancingStatus;
            existingForm.CreditAssessment = lrrForm.CreditAssessment;
            existingForm.LdApplicable = lrrForm.LdApplicable;
            existingForm.LdCapping = lrrForm.LdCapping;
            existingForm.LdClause = lrrForm.LdClause;
            existingForm.IdentifiedRisk = lrrForm.IdentifiedRisk;
            existingForm.MitigationPlan = lrrForm.MitigationPlan;
            existingForm.DeliveryIncoterms = lrrForm.DeliveryIncoterms;
            existingForm.TaxExposure = lrrForm.TaxExposure;
            existingForm.Comments = lrrForm.Comments;
            existingForm.Confirmation = lrrForm.Confirmation;
            existingForm.PfBidValue = lrrForm.PfBidValue;
            existingForm.PfGrossMargin = lrrForm.PfGrossMargin;
            existingForm.PfNetMargin = lrrForm.PfNetMargin;
            existingForm.PfWarrantyProv = lrrForm.PfWarrantyProv;
            existingForm.PfInflation = lrrForm.PfInflation;
            existingForm.PfContingencies = lrrForm.PfContingencies;
            existingForm.PfRiskProv = lrrForm.PfRiskProv;
            existingForm.PfTotalProv = lrrForm.PfTotalProv;
            existingForm.PfMatCost = lrrForm.PfMatCost;
            existingForm.PfDeltaRR = lrrForm.PfDeltaRR;
            existingForm.PfApprovalComments = lrrForm.PfApprovalComments;
            existingForm.PptOutput = lrrForm.PptOutput;
            existingForm.UpdatedAt = DateTime.UtcNow;

            await _context.SaveChangesAsync();
            return existingForm;
        }

        public async Task<bool> DeleteLrrFormAsync(int id)
        {
            var lrrForm = await _context.LrrForms.FindAsync(id);
            if (lrrForm == null)
                return false;

            _context.LrrForms.Remove(lrrForm);
            await _context.SaveChangesAsync();
            return true;
        }

        // RrChecklist methods
        public async Task<IEnumerable<RrChecklist>> GetAllRrChecklistsAsync()
        {
            return await _context.RrChecklists.ToListAsync();
        }

        public async Task<RrChecklist?> GetRrChecklistByIdAsync(int id)
        {
            return await _context.RrChecklists.FindAsync(id);
        }

        public async Task<RrChecklist> CreateRrChecklistAsync(RrChecklist rrChecklist)
        {
            rrChecklist.CreatedDate = DateTime.UtcNow;
            rrChecklist.UpdatedDate = DateTime.UtcNow;
            
            _context.RrChecklists.Add(rrChecklist);
            await _context.SaveChangesAsync();
            return rrChecklist;
        }

        public async Task<RrChecklist?> UpdateRrChecklistAsync(int id, RrChecklist rrChecklist)
        {
            var existingChecklist = await _context.RrChecklists.FindAsync(id);
            if (existingChecklist == null)
                return null;

            existingChecklist.Criteria1 = rrChecklist.Criteria1;
            existingChecklist.Criteria2 = rrChecklist.Criteria2;
            existingChecklist.Criteria3 = rrChecklist.Criteria3;
            existingChecklist.Description = rrChecklist.Description;
            existingChecklist.Priority = rrChecklist.Priority;
            existingChecklist.Status = rrChecklist.Status;
            existingChecklist.UpdatedDate = DateTime.UtcNow;

            await _context.SaveChangesAsync();
            return existingChecklist;
        }

        public async Task<bool> DeleteRrChecklistAsync(int id)
        {
            var rrChecklist = await _context.RrChecklists.FindAsync(id);
            if (rrChecklist == null)
                return false;

            _context.RrChecklists.Remove(rrChecklist);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}

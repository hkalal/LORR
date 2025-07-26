
using LrrApp.Models;

namespace LrrApp.Services
{
    public interface ILrrService
    {
        Task<IEnumerable<LrrForm>> GetAllLrrFormsAsync();
        Task<LrrForm?> GetLrrFormByIdAsync(int id);
        Task<LrrForm> CreateLrrFormAsync(LrrForm lrrForm);
        Task<LrrForm?> UpdateLrrFormAsync(int id, LrrForm lrrForm);
        Task<bool> DeleteLrrFormAsync(int id);

        Task<IEnumerable<RrChecklist>> GetAllRrChecklistsAsync();
        Task<RrChecklist?> GetRrChecklistByIdAsync(int id);
        Task<RrChecklist> CreateRrChecklistAsync(RrChecklist rrChecklist);
        Task<RrChecklist?> UpdateRrChecklistAsync(int id, RrChecklist rrChecklist);
        Task<bool> DeleteRrChecklistAsync(int id);
    }
}

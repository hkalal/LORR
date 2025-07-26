
using System.ComponentModel.DataAnnotations;

namespace LrrApp.Models
{
    public class RrChecklist
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Criteria1 { get; set; } = string.Empty;

        [Required]
        public string Criteria2 { get; set; } = string.Empty;

        [Required]
        public string Criteria3 { get; set; } = string.Empty;

        public string? Description { get; set; }
        public string? Priority { get; set; }
        public string? Status { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedDate { get; set; } = DateTime.UtcNow;
    }
}

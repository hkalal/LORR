
using Microsoft.AspNetCore.Mvc;
using LrrApp.Models;
using LrrApp.Services;

namespace LrrApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RrChecklistsController : ControllerBase
    {
        private readonly ILrrService _lrrService;

        public RrChecklistsController(ILrrService lrrService)
        {
            _lrrService = lrrService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<RrChecklist>>> GetRrChecklists()
        {
            var checklists = await _lrrService.GetAllRrChecklistsAsync();
            return Ok(checklists);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<RrChecklist>> GetRrChecklist(int id)
        {
            var checklist = await _lrrService.GetRrChecklistByIdAsync(id);
            if (checklist == null)
            {
                return NotFound();
            }
            return Ok(checklist);
        }

        [HttpPost]
        public async Task<ActionResult<RrChecklist>> CreateRrChecklist(RrChecklist rrChecklist)
        {
            try
            {
                var createdChecklist = await _lrrService.CreateRrChecklistAsync(rrChecklist);
                return CreatedAtAction(nameof(GetRrChecklist), new { id = createdChecklist.Id }, createdChecklist);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error creating RR checklist: {ex.Message}");
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateRrChecklist(int id, RrChecklist rrChecklist)
        {
            try
            {
                var updatedChecklist = await _lrrService.UpdateRrChecklistAsync(id, rrChecklist);
                if (updatedChecklist == null)
                {
                    return NotFound();
                }
                return Ok(updatedChecklist);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error updating RR checklist: {ex.Message}");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRrChecklist(int id)
        {
            var result = await _lrrService.DeleteRrChecklistAsync(id);
            if (!result)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}


using Microsoft.AspNetCore.Mvc;
using LrrApp.Models;
using LrrApp.Services;

namespace LrrApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LrrFormsController : ControllerBase
    {
        private readonly ILrrService _lrrService;

        public LrrFormsController(ILrrService lrrService)
        {
            _lrrService = lrrService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<LrrForm>>> GetLrrForms()
        {
            var lrrForms = await _lrrService.GetAllLrrFormsAsync();
            return Ok(lrrForms);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<LrrForm>> GetLrrForm(int id)
        {
            var lrrForm = await _lrrService.GetLrrFormByIdAsync(id);
            if (lrrForm == null)
            {
                return NotFound();
            }
            return Ok(lrrForm);
        }

        [HttpPost]
        public async Task<ActionResult<LrrForm>> CreateLrrForm(LrrForm lrrForm)
        {
            try
            {
                var createdForm = await _lrrService.CreateLrrFormAsync(lrrForm);
                return CreatedAtAction(nameof(GetLrrForm), new { id = createdForm.Id }, createdForm);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error creating LRR form: {ex.Message}");
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateLrrForm(int id, LrrForm lrrForm)
        {
            try
            {
                var updatedForm = await _lrrService.UpdateLrrFormAsync(id, lrrForm);
                if (updatedForm == null)
                {
                    return NotFound();
                }
                return Ok(updatedForm);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error updating LRR form: {ex.Message}");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLrrForm(int id)
        {
            var result = await _lrrService.DeleteLrrFormAsync(id);
            if (!result)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}

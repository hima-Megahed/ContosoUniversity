using ContosoUniversity.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LevelUpUniversity.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectsController : ControllerBase
    {
        private readonly ISubjectsRepository _subjectsRepository;

        public SubjectsController(ISubjectsRepository subjectsRepository)
        {
            _subjectsRepository = subjectsRepository;
        }

        
        [HttpGet]
        public async Task<IActionResult> GetSubjects()
        {
            return Ok(await _subjectsRepository.GetAllSubjects());
        }
    }
}

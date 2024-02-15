using Education.Application.DTOs;
using Education.Application.Interfaces;
using Education.Application.VIewModels;
using Microsoft.AspNetCore.Mvc;

namespace Education.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private readonly ISubjectService _subjectService;
        public SubjectController(ISubjectService subjectService)
        {
            _subjectService = subjectService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateSubject([FromForm] SubjectDTO subjectDTO)
        {
            bool result = await _subjectService.CreateAsync(subjectDTO);

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllSubject()
        {
            IList<SubjectViewModel> subjects = await _subjectService.GetAllAsync();

            return Ok(subjects);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSubject(string name, [FromBody] SubjectDTO subjectDTO) 
        {
            bool result = await _subjectService.UpdateAsync(name, subjectDTO);

            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteSubject(string name)
        {
            bool result = await _subjectService.DeleteAsync(name);

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetSubjectByName(string name)
        {
            SubjectViewModel subject = await _subjectService.GetByNameAsync(name);

            return Ok(subject);
        }

        [HttpGet]
        public async Task<IActionResult> GetSubjectCount()
        {
            int count = await _subjectService.GetCountAsync();

            return Ok(count);
        }
    }
}

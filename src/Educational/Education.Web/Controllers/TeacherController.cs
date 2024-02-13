using Education.Application.DTOs;
using Education.Application.Interfaces;
using Education.Application.VIewModels;
using Microsoft.AspNetCore.Mvc;

namespace Education.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherService _service;

        public TeacherController(ITeacherService service)
        {
            _service = service;
        }
        [HttpPost]
        public async Task<IActionResult> CreateTeacher(TeacherDTO teacherDTO)
        {
            bool result = await _service.CreateAsync(teacherDTO);

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTeacher()
        {
            IList<TeacherViewModel> teachers = await _service.GetAllAsync();

            return Ok(teachers);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTeacher(int id, TeacherDTO teacher)
        {
            bool result = await _service.UpdateAsync(id, teacher);

            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteTeacher(int id)
        {
            bool result = await _service.DeleteAsync(id);

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetTeacherById(int id)
        {
            TeacherViewModel teacher = await _service.GetTeacherByIdAsync(id);

            return Ok(teacher);
        }

        [HttpGet]
        public async Task<IActionResult> GetTeacherCount()
        {
            long count = await _service.GetCountAsync();

            return Ok(count);
        }
    }
}

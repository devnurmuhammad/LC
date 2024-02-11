using Education.Application.DTOs;
using Education.Application.Interfaces;
using Education.Application.VIewModels;
using Microsoft.AspNetCore.Mvc;

namespace Education.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateStudent([FromForm] StudentDTO student)
        {
            bool result = await _studentService.CreateAsync(student);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllStudents()
        {
            IList<StudentViewModel> students = await _studentService.GetAllAsync();

            return Ok(students);
        }

        [HttpGet]
        public async Task<IActionResult> GetStudentById(int id)
        {
            StudentViewModel student = await _studentService.GetStudentById(id);

            return Ok(student);
        }
    }
}

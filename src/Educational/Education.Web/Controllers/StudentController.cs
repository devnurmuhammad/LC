using Education.Application.DTOs;
using Education.Application.Interfaces;
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
        public async Task<IActionResult> CreateStudent(StudentDTO student)
        {
            bool result = await _studentService.CreateAsync(student);
            return Ok(result);
        }
    }
}

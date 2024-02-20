using Microsoft.AspNetCore.Mvc;
using Organizational.Application.DTOs;
using Organizational.Application.Interfaces.Services;
using Organizational.Application.ViewModels;
using Organizational.Domain.Entities;

namespace Organizational.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _service;
        public EmployeeController(IEmployeeService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> CreateEmployee(EmployeeDTO employeeDTO)
        {
            bool result = await _service.CreateEmployee(employeeDTO);

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEmployee()
        {
            IList<EmployeeViewModel> employees = await _service.GetAllEmployees();

            return Ok(employees);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateEmployee(int id, EmployeeDTO employeeDTO)
        {
            bool result = await _service.UpdateEmployee(id, employeeDTO);

            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            bool result = await _service.DeleteEmployee(id);

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetEmployeeById(int id)
        {
            EmployeeViewModel employee = await _service.GetEmployeeById(id);

            return Ok(employee);
        }

        [HttpGet]
        public async Task<IActionResult> GetEmployeeCount()
        {
            int result = await _service.GetEmployeeCount();

            return Ok(result);
        }
    }
}

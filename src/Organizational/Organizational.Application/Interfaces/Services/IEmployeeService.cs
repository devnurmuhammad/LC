using Organizational.Application.DTOs;
using Organizational.Application.ViewModels;

namespace Organizational.Application.Interfaces.Services
{
    public interface IEmployeeService
    {
        public Task<bool> CreateEmployee(EmployeeDTO employeeDTO);
        public Task<IList<EmployeeViewModel>> GetAllEmployees();
        public Task<bool> UpdateEmployee(int id,  EmployeeDTO employeeDTO);
        public Task<bool> DeleteEmployee(int id);
        public Task<EmployeeViewModel> GetEmployeeById(int id);
        public Task<int> GetEmployeeCount();
    }
}

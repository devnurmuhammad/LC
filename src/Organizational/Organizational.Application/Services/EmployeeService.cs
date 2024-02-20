using Organizational.Application.DTOs;
using Organizational.Application.Interfaces.Repositories;
using Organizational.Application.Interfaces.Services;
using Organizational.Application.ViewModels;
using Organizational.Domain.Entities;
using Organizational.Domain.Enums;

namespace Organizational.Application.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<bool> CreateEmployee(EmployeeDTO employeeDTO)
        {
            Employee employee = new Employee()
            {
                Firstname = employeeDTO.Firstname,
                Middlename = employeeDTO.Middlename,
                Lastname = employeeDTO.Lastname,
                Email = employeeDTO.Email,
                Address = employeeDTO.Address,
                Phone = employeeDTO.Phone,
                Position = employeeDTO.Position,
                Salary = employeeDTO.Salary,
                EmploymentDate = employeeDTO.EmploymentDate,
                BranchId = employeeDTO.BranchId,
                Comment = employeeDTO.Comment,
                Passport = employeeDTO.Passport,
                IsActive = employeeDTO.IsActive,
            };
            bool result = await _employeeRepository.CreateEmployee(employee);

            return result;
        }

        public async Task<bool> DeleteEmployee(int id)
        {
            Employee employee = await _employeeRepository.GetEmployeeById(id);
            if (employee == null)
            {
                throw new Exception("not found");
            }
            bool result = await _employeeRepository.DeleteEmployee(id);

            return result;
        }

        public async Task<IList<EmployeeViewModel>> GetAllEmployees()
        {
            IList<Employee> employees = await _employeeRepository.GetAllEmployee();
            IList<EmployeeViewModel> result = employees.Select(x => new EmployeeViewModel()
            {
                Id = x.Id,
                Firstname = x.Firstname,
                Middlename = x.Middlename,
                Lastname = x.Lastname,
                Salary = x.Salary,
                Address = x.Address,
                Passport = x.Passport,
                IsActive = x.IsActive,
                EmploymentDate = x.EmploymentDate,
                BranchId = x.BranchId,
                Email = x.Email,
                Phone = x.Phone,
                Position = Enum.GetName(typeof(EmployeePosition), (int)x.Position),
                Comment = x.Comment,
                Contracts = x.Contracts,
                EmployeeOutcomes = x.EmployeeOutcomes,
            }).ToList();

            return result;
        }

        public async Task<EmployeeViewModel> GetEmployeeById(int id)
        {
            Employee x = await _employeeRepository.GetEmployeeById(id);
            EmployeeViewModel employee = new EmployeeViewModel()
            {
                Id = x.Id,
                Firstname = x.Firstname,
                Middlename = x.Middlename,
                Lastname = x.Lastname,
                Salary = x.Salary,
                Address = x.Address,
                Passport = x.Passport,
                IsActive = x.IsActive,
                EmploymentDate = x.EmploymentDate,
                BranchId = x.BranchId,
                Email = x.Email,
                Phone = x.Phone,
                Position = Enum.GetName(typeof(EmployeePosition), (int)x.Position),
                Comment = x.Comment,
                Contracts = x.Contracts,
                EmployeeOutcomes = x.EmployeeOutcomes,
            };

            return employee;
        }

        public async Task<int> GetEmployeeCount()
        {
            int result = await _employeeRepository.GetEmployeeCount();

            return result;
        }

        public async Task<bool> UpdateEmployee(int id, EmployeeDTO employeeDTO)
        {
            Employee employee = await _employeeRepository.GetEmployeeById(id);
            if (employee == null)
            {
                throw new Exception("not found");
            }
            employee.Firstname = employeeDTO.Firstname;
            employee.Middlename = employeeDTO.Middlename;
            employee.Lastname = employeeDTO.Lastname;
            employee.Email = employeeDTO.Email;
            employee.Phone = employeeDTO.Phone;
            employee.Position = employeeDTO.Position;
            employee.Comment = employeeDTO.Comment;
            employee.Address = employeeDTO.Address;
            employee.BranchId = employeeDTO.BranchId;
            employee.EmploymentDate = employeeDTO.EmploymentDate;
            employee.IsActive = employeeDTO.IsActive;
            employee.Passport = employeeDTO.Passport;
            employee.Salary = employeeDTO.Salary;

            bool result = await _employeeRepository.UpdateEmployee(employee);

            return result;
        }
    }
}

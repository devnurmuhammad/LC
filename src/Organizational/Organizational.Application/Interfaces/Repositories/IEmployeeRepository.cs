using Organizational.Domain.Entities;

namespace Organizational.Application.Interfaces.Repositories
{
    public interface IEmployeeRepository
    {
        public Task<bool> CreateEmployee(Employee employee);
        public Task<IList<Employee>> GetAllEmployee();
        public Task<bool> UpdateEmployee(Employee employee);
        public Task<bool> DeleteEmployee(int id);
        public Task<Employee> GetEmployeeById(int id);
        public Task<int> GetEmployeeCount();
    }
}

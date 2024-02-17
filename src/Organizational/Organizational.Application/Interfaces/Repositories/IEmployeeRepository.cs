using Organizational.Domain.Entities;

namespace Organizational.Application.Interfaces.Repositories
{
    public interface IEmployeeRepository
    {
        public Task<bool> CreateEmployee(Employee employee);
        public Task<IList<Employee>> GetAllEmployee();
        public Task<bool> UpdateEmployee(int id);
        //public Task<bool> DeleteEmployee(int id);
        public Task<IList<Employee>> GetEmployeeByName(string name);
        public Task<int> GetEmployeeCount();
    }
}

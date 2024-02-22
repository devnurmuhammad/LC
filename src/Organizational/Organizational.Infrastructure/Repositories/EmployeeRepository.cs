using Microsoft.EntityFrameworkCore;
using Organizational.Application.Interfaces.Repositories;
using Organizational.Domain.Entities;
using Organizational.Infrastructure.Data;

namespace Organizational.Infrastructure.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly OrganizationDbContext _context;
        public EmployeeRepository(OrganizationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateEmployee(Employee employee)
        {
            await _context.Employees.AddAsync(employee);
            int result = await _context.SaveChangesAsync();

            return result > 0;
        }

        public async Task<bool> DeleteEmployee(int id)
        {
            Employee? employee = await _context.Employees.FirstOrDefaultAsync(x => x.Id == id);

            _context.Employees.Remove(employee);
            int result = await _context.SaveChangesAsync();
            return result > 0;
        }

        public async Task<IList<Employee>> GetAllEmployee()
        {
            IList<Employee> employees = await _context.Employees.Include(e => e.EmployeeOutcomes)
                .Include(x => x.Contracts)
                .ToListAsync();

            return employees;
        }

        public async Task<Employee> GetEmployeeById(int id)
        {
            Employee? employee = await _context.Employees.Include(e => e.EmployeeOutcomes)
                .Include(x => x.Contracts)
                .FirstOrDefaultAsync(_ => _.Id == id);

            return employee;
        }

        public async Task<int> GetEmployeeCount()
        {
            int count = await _context.Employees.CountAsync();

            return count;
        }

        public async Task<bool> UpdateEmployee(Employee employee)
        {
            Employee? result = await _context.Employees.FirstOrDefaultAsync(x => x.Id == employee.Id);
            _context.Employees.Update(result);
            int res = await _context.SaveChangesAsync();

            return res > 0;
        }
    }
}

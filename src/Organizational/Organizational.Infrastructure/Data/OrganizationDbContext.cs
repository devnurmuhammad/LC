using Microsoft.EntityFrameworkCore;
using Organizational.Domain.Entities;

namespace Organizational.Infrastructure.Data
{
    public class OrganizationDbContext : DbContext
    {
        public OrganizationDbContext(DbContextOptions<OrganizationDbContext> options) : base(options) 
        {
            Database.Migrate();
        }

        public DbSet<Company> Company { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Income> Incomes { get; set; }
        public DbSet<Outcome> Outcomes { get; set; }
        public DbSet<EmployeeOutcome> EmployeeOutcomes { get; set; }
    }
}

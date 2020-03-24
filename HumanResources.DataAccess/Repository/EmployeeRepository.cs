using HumanResources.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.DataAccess.Repository
{
    public class EmployeeRepository : IRepository<Employee>
    {
        private ApplicationDbContext context;

        public EmployeeRepository()
        {
            context = new ApplicationDbContext();
        }
        public async Task<IEnumerable<Employee>> GetAllAsync()
        {
            return await context.Employees.ToListAsync();
        }
    }
}

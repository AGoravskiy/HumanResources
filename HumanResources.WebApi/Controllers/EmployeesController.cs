using HumanResources.DataAccess.Model;
using HumanResources.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;


namespace HumanResources.WebApi.Controllers
{
    [RoutePrefix("api/employees")]
    public class EmployeesController : ApiController
    {
        private readonly IRepository<Employee> _employeeRepository;

        public EmployeesController(IRepository<Employee> employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpGet]
        [Route("")]
        public async Task<IHttpActionResult> GetEmployeesAsync()
        {
            var employees = await _employeeRepository.GetAllAsync();

            if (employees == null)
            {
                return NotFound();
            }

            return Ok(employees);
        }
    }
}
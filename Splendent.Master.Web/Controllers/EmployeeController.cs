using Splendent.Master.Api.Dto;
using Splendent.Master.BusinessLogic.Interfaces;
using Splendent.Masters.BusinessLogic;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;

namespace Splendent.Master.Web.Controllers
{
    [RoutePrefix("api/employee")]
    public class EmployeeController : BaseApiController
    {
        private readonly IEmployeeBL _employeeBL;
        public EmployeeController(IEmployeeBL employeeBL)
        {
            _employeeBL = employeeBL;
        }
        
        [Route("getemployees"), HttpGet]
        [ResponseType(typeof(List<Employee>))]
        public List<Employee> GetEmployees()
        {
            return _employeeBL.GetEmployee();
        }

        [Route("getemployee"), HttpGet]
        [ResponseType(typeof(Employee))]
        public Employee GetEmployee(int EmployeeID)
        {
            return _employeeBL.GetEmployee(EmployeeID);
        }
    }
}
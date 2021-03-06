﻿using Splendent.Master.Api.Dto;
using Splendent.Master.BusinessLogic.Interfaces;
using Splendent.Master.Web.Swagger;
using System.Collections.Generic;
using System.Threading.Tasks;
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

        [Route("testEmployeeApi"), HttpGet]
        [ResponseType(typeof(string))]
        //[HideInSwagger]
        public async Task<IHttpActionResult> TestEmployeeApi()
        {
            return Ok(await Task.FromResult("Test Employee Api"));
        }

        [Route("getemployees"), HttpGet]
        [ResponseType(typeof(List<Employee>))]
        public async Task<IHttpActionResult> GetEmployees()
        {
            return Ok(await _employeeBL.GetEmployee());
        }

        [Route("getemployee"), HttpGet]
        [ResponseType(typeof(Employee))]
        public async Task<IHttpActionResult> GetEmployee(int EmployeeID)
        {
            return Ok(await _employeeBL.GetEmployee(EmployeeID));
        }
        
    }
}
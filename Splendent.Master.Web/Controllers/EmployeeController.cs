﻿using System.Web.Http;
using System.Web.Http.Description;

namespace Splendent.Master.Web.Controllers
{
    [RoutePrefix("api/employee")]
    public class EmployeeController : BaseApiController
    {
        
        [Route("get"), HttpGet]
        [ResponseType(typeof(string))]
        public string GetEmployees()
        {
            return "EmployeeName";
        }
    }
}
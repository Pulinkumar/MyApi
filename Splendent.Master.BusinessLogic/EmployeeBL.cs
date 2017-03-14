using Splendent.Master.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Splendent.Master.Api.Dto;
using Splendent.Master.Common.MockData;

namespace Splendent.Masters.BusinessLogic
{
    public class EmployeeBL : IEmployeeBL
    {
        public EmployeeBL()
        {

        }

        public Task<List<Employee>> GetEmployee()
        {
            var employeeMock = new EmployeeMock();
            return Task.FromResult(employeeMock.GetEmployeeMockData());
        }

        public Task<Employee> GetEmployee(int EmployeeID)
        {
            var employeeMock = new EmployeeMock();
            return Task.FromResult(employeeMock.GetEmployeeMockData(EmployeeID));
        }
    }
}

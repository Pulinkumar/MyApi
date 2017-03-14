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

        public List<Employee> GetEmployee()
        {
            var employeeMock = new EmployeeMock();
            return employeeMock.GetEmployeeMockData();
        }

        public Employee GetEmployee(int EmployeeID)
        {
            var employeeMock = new EmployeeMock();
            return employeeMock.GetEmployeeMockData(EmployeeID);
        }
    }
}

using Splendent.Master.Api.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Splendent.Master.Common.MockData
{
    public class EmployeeMock
    {
        private readonly List<Employee> _employees;

        public EmployeeMock()
        {
            _employees = new List<Employee> {
                new Employee { EmployeeID = 1, FirstName = "Pulin", LastName = "Patel", Address = new Address { Address1 = "1719 Robin Dr", Address2 = "", City = "Bensalem", State = "PA", Zipcode = "19020", Country = "USA" } },
                new Employee { EmployeeID = 2, FirstName = "Reshma", LastName = "Patel", Address = new Address { Address1 = "1719 Robin Dr", Address2 = "", City = "Bensalem", State = "PA", Zipcode = "19020", Country = "USA" } },
            };
        }

        public List<Employee> GetEmployeeMockData()
        {
            return _employees;
        }

        public Employee GetEmployeeMockData(int EmployeeID)
        {
            return _employees.Single(e => e.EmployeeID == EmployeeID);
        }
    }
}

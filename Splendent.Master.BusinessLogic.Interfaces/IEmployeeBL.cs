using Splendent.Master.Api.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Splendent.Master.BusinessLogic.Interfaces
{
    public interface IEmployeeBL
    {
        Task<List<Employee>> GetEmployee();
        Task<Employee> GetEmployee(int EmployeeID);

    }
}

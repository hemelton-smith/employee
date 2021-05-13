using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Employee.Domain.Employees
{
    public interface IEmployeeGateway
    {
        Task CreateEmployee(Employee employee);
        Task UpdateEmployee(Employee employee);
        Task DeleteEmployee(Guid employeeId);
        Task <List<Employee>> GetAllEmployees();
    }
}

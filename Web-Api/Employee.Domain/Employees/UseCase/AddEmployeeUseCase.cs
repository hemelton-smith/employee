using Employee.Domain.Output;
using System.Threading.Tasks;

namespace Employee.Domain.Employees.UseCase
{
    public class AddEmployeeUseCase : IAddEmployeeUseCase
    {
        private readonly IEmployeeGateway _employeeGateway;

        public AddEmployeeUseCase(IEmployeeGateway employeeGateway)
        {
            _employeeGateway = employeeGateway;
        }

        public async Task AddEmployee(Employee employee, IErrorActionResultPresenter<string> presenter)
        {
            await _employeeGateway.CreateEmployee(employee);
        }
    }
}

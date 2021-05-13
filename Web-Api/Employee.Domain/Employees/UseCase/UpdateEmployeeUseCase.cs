using Employee.Domain.Output;
using System.Threading.Tasks;

namespace Employee.Domain.Employees.UseCase
{
    public class UpdateEmployeeUseCase : IUpdateEmployeeUseCase
    {
        private readonly IEmployeeGateway _employeeGateway;

        public UpdateEmployeeUseCase(IEmployeeGateway employeeGateway)
        {
            _employeeGateway = employeeGateway;
        }
        public async Task UpdateEmployee(Employee employee, IErrorActionResultPresenter<string> presenter)
        {
            await _employeeGateway.UpdateEmployee(employee);
        }
    }
}

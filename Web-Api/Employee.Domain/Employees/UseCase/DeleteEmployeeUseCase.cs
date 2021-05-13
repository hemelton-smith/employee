using Employee.Domain.Output;
using System;
using System.Threading.Tasks;

namespace Employee.Domain.Employees.UseCase
{
    public class DeleteEmployeeUseCase : IDeleteEmployeeUseCase
    {
        private readonly IEmployeeGateway _employeeGateway;
        public DeleteEmployeeUseCase(IEmployeeGateway employeeGateway)
        {
            _employeeGateway = employeeGateway;
        }

        public async Task DeleteEmployee(Guid employeeId, IErrorActionResultPresenter<string> presenter)
        {
            await _employeeGateway.DeleteEmployee(employeeId);
        }
    }
}

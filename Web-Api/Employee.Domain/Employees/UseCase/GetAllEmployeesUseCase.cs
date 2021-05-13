using Employee.Domain.Output;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Employee.Domain.Employees.UseCase
{
    public class GetAllEmployeesUseCase : IGetAllEmployeesUseCase
    {
        private readonly IEmployeeGateway _employeeGateway;
        public GetAllEmployeesUseCase(IEmployeeGateway employeeGateway)
        {
            _employeeGateway = employeeGateway;
        }
        public async Task<List<Employee>> GetAllEmployees()
        {
            return await _employeeGateway.GetAllEmployees();
        }

        public async Task GetAllEmployees(ISuccessOrErrorActionResultPresenter<List<Employee>, ErrorDto> presenter)
        {
            var employees = await _employeeGateway.GetAllEmployees();

            if (employees.Count > 0)
            {
                presenter.Success(employees);
            }
            else
            {
                presenter.Error(new ErrorDto
                {
                    Message = "No employees found"
                });
            }
        }
    }
}

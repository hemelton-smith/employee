using Employee.Domain.Employees.UseCase;
using Employee.Domain.Output;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Employee.Web.Api.Employees
{
    [ApiController]
    [Route("updateemployee")]
    public class UpdateEmployeeController : ControllerBase
    {
        private readonly IUpdateEmployeeUseCase _updateEmployeeUseCase;
        private readonly IErrorActionResultPresenter<string> _presenter;

        public UpdateEmployeeController(IUpdateEmployeeUseCase updateEmployeeUseCase, IErrorActionResultPresenter<string> presenter)
        {
            _updateEmployeeUseCase = updateEmployeeUseCase;
            _presenter = presenter;
        }

        [HttpPut]
        public async Task<IActionResult> UpdateEmployee(Domain.Employees.Employee employee)
        {
            await _updateEmployeeUseCase.UpdateEmployee(employee, _presenter);
            return _presenter.Render();
        }
    }
}

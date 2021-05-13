using Employee.Domain.Employees.UseCase;
using Employee.Domain.Output;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Employee.Web.Api.Employees
{
    [ApiController]
    [Route("deleteemployee")]
    public class DeleteEmployeeController : ControllerBase
    {
        private readonly IDeleteEmployeeUseCase _deleteEmployeeUseCase;
        private readonly IErrorActionResultPresenter<string> _presenter;
        public DeleteEmployeeController(IDeleteEmployeeUseCase deleteEmployeeUseCase,
            IErrorActionResultPresenter<string> presenter)
        {
            _deleteEmployeeUseCase = deleteEmployeeUseCase;
            _presenter = presenter;
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteEmployee(Guid employeeId)
        {
            await _deleteEmployeeUseCase.DeleteEmployee(employeeId, _presenter);
            return _presenter.Render();
        }
    }
}

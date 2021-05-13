using Employee.Domain.Employees.UseCase;
using Employee.Domain.Output;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Employee.Web.Api.Employees
{
    [ApiController]
    [Route("addemployee")]
    public class AddEmployeeController : ControllerBase
    {
        private readonly IAddEmployeeUseCase _addEmeployeeUseCase;
        private readonly IErrorActionResultPresenter<string> _presenter;
        public AddEmployeeController(IAddEmployeeUseCase addEmeployeeUseCase, 
            IErrorActionResultPresenter<string> presenter)
        {
            _addEmeployeeUseCase = addEmeployeeUseCase;
            _presenter = presenter;
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee(Domain.Employees.Employee employee)
        {
            await _addEmeployeeUseCase.AddEmployee(employee, _presenter);
            return _presenter.Render();
        }
    }
}

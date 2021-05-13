using Employee.Domain.Employees.UseCase;
using Employee.Domain.Output;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Employee.Web.Api.Employees
{
    [ApiController]
    [Route("getallemployees")]
    public class GetAllEmployeesController : ControllerBase
    {
        private readonly IGetAllEmployeesUseCase _getAllEmployeesUseCase;
        private readonly ISuccessOrErrorActionResultPresenter<List<Domain.Employees.Employee>, ErrorDto> _presenter;
        public GetAllEmployeesController(IGetAllEmployeesUseCase getAllEmployeesUseCase,
            ISuccessOrErrorActionResultPresenter<List<Domain.Employees.Employee>, ErrorDto> presenter)
        {
            _getAllEmployeesUseCase = getAllEmployeesUseCase;
            _presenter = presenter;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEmployees()
        {
             await _getAllEmployeesUseCase.GetAllEmployees(_presenter);
           return _presenter.Render();
        }
    }
}

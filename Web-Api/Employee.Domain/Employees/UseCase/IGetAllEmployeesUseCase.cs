using Employee.Domain.Output;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Employee.Domain.Employees.UseCase
{
    public interface IGetAllEmployeesUseCase
    {
        Task GetAllEmployees(ISuccessOrErrorActionResultPresenter<List<Employee>, ErrorDto> presenter);
    }
}

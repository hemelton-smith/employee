using Employee.Domain.Output;
using System;
using System.Threading.Tasks;

namespace Employee.Domain.Employees.UseCase
{
    public interface IDeleteEmployeeUseCase
    {
        Task DeleteEmployee(Guid employeeId, IErrorActionResultPresenter<string> presenter);
    }
}

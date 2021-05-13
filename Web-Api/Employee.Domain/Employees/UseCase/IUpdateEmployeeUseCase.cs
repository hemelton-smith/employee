using Employee.Domain.Output;
using System.Threading.Tasks;

namespace Employee.Domain.Employees.UseCase
{
    public interface IUpdateEmployeeUseCase
    {
        Task UpdateEmployee(Employee employee, IErrorActionResultPresenter<string> presenter);
    }
}

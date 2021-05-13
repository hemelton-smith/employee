using Employee.Domain.Output;
using System.Threading.Tasks;

namespace Employee.Domain.Employees.UseCase
{
    public interface IAddEmployeeUseCase
    {
        Task AddEmployee(Employee employee, IErrorActionResultPresenter<string> presenter);
    }
}

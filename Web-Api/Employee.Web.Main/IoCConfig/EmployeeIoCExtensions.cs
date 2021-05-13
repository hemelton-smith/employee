using Employee.Domain.Employees;
using Employee.Domain.Employees.UseCase;
using Employee.Integration.Sql.Employees;
using Microsoft.Extensions.DependencyInjection;

namespace Employee.Web.Main.IoCConfig
{
    public static class EmployeeIoCExtensions
    {
        public static IServiceCollection AddEmployee(this IServiceCollection services)
        {
            services.AddScoped<IEmployeeGateway, EmployeeGateway>();
            services.AddScoped<IAddEmployeeUseCase, AddEmployeeUseCase>();
            services.AddScoped<IUpdateEmployeeUseCase, UpdateEmployeeUseCase>();
            services.AddScoped<IGetAllEmployeesUseCase, GetAllEmployeesUseCase>();
            services.AddScoped<IDeleteEmployeeUseCase, DeleteEmployeeUseCase>();
            return services;
        }
    }
}

using Employee.Domain.Output;
using Microsoft.Extensions.DependencyInjection;

namespace Employee.Web.Main.IoCConfig
{
    public static class PresenterIoCException
    {
        public static IServiceCollection AddPresenters(this IServiceCollection services)
        {
            services.AddScoped(typeof(ISuccessOrErrorActionResultPresenter<,>), typeof(SuccessOrErrorRestPresenter<,>));
            services.AddScoped(typeof(IErrorActionResultPresenter<>), typeof(ErrorRestPresenter<>));

            return services;
        }
    }
}

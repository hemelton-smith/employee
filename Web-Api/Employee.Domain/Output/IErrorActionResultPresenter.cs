using Microsoft.AspNetCore.Mvc;

namespace Employee.Domain.Output
{
    public interface IErrorActionResultPresenter<in TError> : IErrorPresenter<TError>
    {
        public IActionResult Render();
    }
}

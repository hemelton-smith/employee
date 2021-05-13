using Microsoft.AspNetCore.Mvc;

namespace Employee.Domain.Output
{
    public class ErrorRestPresenter<T> : IErrorActionResultPresenter<T>
    {
        private T _error;

        public void Error(T error)
        {
            _error = error;
        }

        public IActionResult Render()
        {
            if (_error == null) return new OkResult();

            return new BadRequestObjectResult(_error);
        }
    }
}

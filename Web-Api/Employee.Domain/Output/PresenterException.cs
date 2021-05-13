using System;

namespace Employee.Domain.Output
{
    public class PresenterException : Exception
    {
        public PresenterException(string message) : base(message)
        {
        }
    }
}

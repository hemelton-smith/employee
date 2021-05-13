using System;

namespace Employee.Domain.Employees
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string FistName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string CellNumber { get; set; }
        public string Department { get; set; }
        public DateTime DateOfJoining { get; set; }
    }
}

using Dapper;
using Employee.Domain.Employees;
using Employee.Integration.Sql.Connections;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Employee.Integration.Sql.Employees
{
    public class EmployeeGateway : IEmployeeGateway
    {
        private readonly IClientManagerDbConnectionContext _context;
        private IDbTransaction DbTransaction => _context.GetTransaction();
        private IDbConnection DbConnection => _context.GetConnection();

        public EmployeeGateway(IClientManagerDbConnectionContext context)
        {
            _context = context;
        }
        public async Task CreateEmployee(Domain.Employees.Employee employee)
        {
            var sql = @"INSERT INTO [Employee]
           ([Id]
           ,[FistName]
           ,[LastName]
           ,[Gender]
           ,[CellNumber]
           ,[Department]
           ,[DateOfJoining])
     VALUES
           (@Id
           , @FistName
           , @LastName
           , @Gender
           , @CellNumber
           , @Department
           , @DateOfJoining)";

            await DbConnection.ExecuteAsync(sql, employee, DbTransaction);
        }

        public async Task UpdateEmployee(Domain.Employees.Employee employee)
        {
            var sql = @"UPDATE [dbo].[Employee]
                       SET 
                       [FistName] = @FistName
                      ,[LastName] = @LastName
                      ,[Gender] = @Gender
                      ,[CellNumber] = @CellNumber
                      ,[Department] = @Department
                      ,[DateOfJoining] = @DateOfJoining
                       WHERE [Id] = @Id";
            await DbConnection.ExecuteAsync(sql, employee, DbTransaction);
        }

        public async Task<List<Domain.Employees.Employee>> GetAllEmployees()
        {
            var employees = await DbConnection.QueryAsync<Domain.Employees.Employee>(@"Select [Id]
                                                                                      ,[FistName]
                                                                                      ,[LastName]
                                                                                      ,[Gender]
                                                                                      ,[CellNumber]
                                                                                      ,[Department]
                                                                                      ,[DateOfJoining] FROM [Employee]", null, DbTransaction);

            return employees.AsList<Domain.Employees.Employee>();
        }

        public async Task DeleteEmployee(System.Guid employeeId)
        {
            var sql = @"DELETE FROM [Employee]
                        WHERE [Id] = @Id";
            await DbConnection.ExecuteAsync(sql, new { Id = employeeId }, DbTransaction);
        }
    }
}

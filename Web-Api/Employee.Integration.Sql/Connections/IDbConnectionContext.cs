using System.Data;

namespace Employee.Integration.Sql.Connections
{
    public interface IDbConnectionContext
    {
        IDbConnection GetConnection();
        IDbTransaction GetTransaction();
        void Commit();
        void Rollback();
    }
}

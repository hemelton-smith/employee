using FluentMigrator;

namespace Employee.Integration.Sql.Migrations
{ 
  
    [Migration(202104182246)]
    public class M01_CreateEmployeeTable : Migration
    {
        public override void Down()
        {
            throw new System.NotImplementedException();
        }

        public override void Up()
        {
            Create.Table("Employee")
                .WithColumn("Id").AsGuid().PrimaryKey("PK_ClientId")
                .WithColumn("FistName").AsString(50)
                .WithColumn("LastName").AsString(50)
                .WithColumn("Gender").AsString(50)
                .WithColumn("CellNumber").AsString(10)
                .WithColumn("Department").AsString(50)
                .WithColumn("DateOfJoining").AsDateTime();
        }
    }
}

namespace HospitalManagementBackend.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Patients");
            DropPrimaryKey("dbo.UserPatientRelations");
            DropPrimaryKey("dbo.Users");
            DropColumn("dbo.Patients", "Id");
            AddColumn("dbo.Patients", "Id", c => c.Guid(nullable: false, identity: true));
            DropColumn("dbo.UserPatientRelations", "UserId");
            AddColumn("dbo.UserPatientRelations", "UserId", c => c.Guid(nullable: false, identity: true));
            DropColumn("dbo.UserPatientRelations", "PatientId");
            AddColumn("dbo.UserPatientRelations", "PatientId", c => c.Guid(nullable: false, identity: true));
            DropColumn("dbo.Users", "Id");
            AddColumn("dbo.Users", "Id", c => c.Guid(nullable: false, identity: true));
            AddPrimaryKey("dbo.Patients", "Id");
            AddPrimaryKey("dbo.UserPatientRelations", "UserId");
            AddPrimaryKey("dbo.Users", "Id");
            DropColumn("dbo.Users", "Depratment");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Depratment", c => c.String());
            DropPrimaryKey("dbo.Users");
            DropPrimaryKey("dbo.UserPatientRelations");
            DropPrimaryKey("dbo.Patients");
            DropColumn("dbo.Patients", "Id");
            AddColumn("dbo.Patients", "Id", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.UserPatientRelations", "UserId");
            AddColumn("dbo.UserPatientRelations", "UserId", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.UserPatientRelations", "PatientId");
            AddColumn("dbo.UserPatientRelations", "PatientId", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.Users", "Id");
            AddColumn("dbo.Users", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Users", "Id");
            AddPrimaryKey("dbo.UserPatientRelations", "UserId");
            AddPrimaryKey("dbo.Patients", "Id");
        }
    }
}

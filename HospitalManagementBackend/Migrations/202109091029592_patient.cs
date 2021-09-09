namespace HospitalManagementBackend.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class patient : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Patients", "Complaint", c => c.String());
            AddColumn("dbo.UserPatientRelations", "Complaint", c => c.String());
            DropColumn("dbo.UserPatientRelations", "Compaint");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserPatientRelations", "Compaint", c => c.String());
            DropColumn("dbo.UserPatientRelations", "Complaint");
            DropColumn("dbo.Patients", "Complaint");
        }
    }
}

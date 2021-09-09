namespace HospitalManagementBackend.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.UserPatientRelations", "ApproverId");
            AddColumn("dbo.UserPatientRelations", "ApproverId", c => c.Guid(nullable: false, identity: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserPatientRelations", "ApproverId");
            AddColumn("dbo.UserPatientRelations", "ApproverId", c => c.Int(nullable: false, identity: true));
        }
    }
}

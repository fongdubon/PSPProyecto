namespace PSPProyecto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cambiosModelo : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "Name", c => c.String(nullable: false, maxLength: 60));
            AlterColumn("dbo.Employees", "LastName", c => c.String(maxLength: 80));
            AlterColumn("dbo.Employees", "Email", c => c.String(maxLength: 200));
            AlterColumn("dbo.Employees", "PhoneNumber", c => c.String(maxLength: 10));
            AlterColumn("dbo.Employees", "Address", c => c.String(maxLength: 200));
            AlterColumn("dbo.Employees", "Photo", c => c.String(maxLength: 200));
            DropColumn("dbo.Employees", "Otro");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "Otro", c => c.String());
            AlterColumn("dbo.Employees", "Photo", c => c.String());
            AlterColumn("dbo.Employees", "Address", c => c.String());
            AlterColumn("dbo.Employees", "PhoneNumber", c => c.String());
            AlterColumn("dbo.Employees", "Email", c => c.String());
            AlterColumn("dbo.Employees", "LastName", c => c.String());
            AlterColumn("dbo.Employees", "Name", c => c.String());
        }
    }
}

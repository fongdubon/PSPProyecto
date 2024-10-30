namespace PSPProyecto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cambiosEmployee : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Otro", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "Otro");
        }
    }
}

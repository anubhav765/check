namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cdct1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tblEmployees", "Name", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tblEmployees", "Name", c => c.Int(nullable: false));
        }
    }
}

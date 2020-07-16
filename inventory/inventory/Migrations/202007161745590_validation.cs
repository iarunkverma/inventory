namespace inventory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class validation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Items", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Items", "Description", c => c.String(nullable: false));
            AlterColumn("dbo.Items", "Price", c => c.String(nullable: true));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Items", "Price", c => c.String());
            AlterColumn("dbo.Items", "Description", c => c.String());
            AlterColumn("dbo.Items", "Name", c => c.String());
        }
    }
}

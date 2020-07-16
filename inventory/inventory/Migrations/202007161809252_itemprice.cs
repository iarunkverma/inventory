namespace inventory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class itemprice : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "ItemPrice", c => c.Int(nullable: false));
            DropColumn("dbo.Items", "Price");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Items", "Price", c => c.Int(nullable: false));
            DropColumn("dbo.Items", "ItemPrice");
        }
    }
}

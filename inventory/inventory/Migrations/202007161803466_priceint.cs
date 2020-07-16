namespace inventory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class priceint : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Items", "Price", c => c.Int(nullable: true));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Items", "Price", c => c.String(nullable: true));
        }
    }
}

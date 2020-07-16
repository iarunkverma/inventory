namespace inventory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class price : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "Price", c => c.String());
            DropColumn("dbo.Items", "Prince");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Items", "Prince", c => c.String());
            DropColumn("dbo.Items", "Price");
        }
    }
}

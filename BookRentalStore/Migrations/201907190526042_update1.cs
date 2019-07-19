namespace BookRentalStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "name", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "name", c => c.String(nullable: false));
        }
    }
}

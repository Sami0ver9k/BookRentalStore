namespace BookRentalStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class isSubscribedToCustomer1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "MembershipTypeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "MembershipTypeId", c => c.Byte(nullable: false));
        }
    }
}

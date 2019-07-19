namespace BookRentalStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "membershiptype_id", "dbo.MembershipTypes");
            DropIndex("dbo.Customers", new[] { "membershiptype_id" });
            AlterColumn("dbo.Customers", "membershiptype_id", c => c.Int(nullable: false));
            CreateIndex("dbo.Customers", "membershiptype_id");
            AddForeignKey("dbo.Customers", "membershiptype_id", "dbo.MembershipTypes", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "membershiptype_id", "dbo.MembershipTypes");
            DropIndex("dbo.Customers", new[] { "membershiptype_id" });
            AlterColumn("dbo.Customers", "membershiptype_id", c => c.Int());
            CreateIndex("dbo.Customers", "membershiptype_id");
            AddForeignKey("dbo.Customers", "membershiptype_id", "dbo.MembershipTypes", "id");
        }
    }
}

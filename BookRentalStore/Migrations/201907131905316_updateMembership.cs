namespace BookRentalStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateMembership : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "package", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "package");
        }
    }
}

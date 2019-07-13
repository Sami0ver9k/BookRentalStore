namespace BookRentalStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "signUpFee", c => c.Int(nullable: false));
            AddColumn("dbo.MembershipTypes", "duration", c => c.Int(nullable: false));
            AddColumn("dbo.MembershipTypes", "discount", c => c.Int(nullable: false));
            DropColumn("dbo.MembershipTypes", "name");
            DropColumn("dbo.MembershipTypes", "isSubscribedToNews");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MembershipTypes", "isSubscribedToNews", c => c.Boolean(nullable: false));
            AddColumn("dbo.MembershipTypes", "name", c => c.String());
            DropColumn("dbo.MembershipTypes", "discount");
            DropColumn("dbo.MembershipTypes", "duration");
            DropColumn("dbo.MembershipTypes", "signUpFee");
        }
    }
}

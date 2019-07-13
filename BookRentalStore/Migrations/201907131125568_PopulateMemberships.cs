namespace BookRentalStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMemberships : DbMigration
    {
        public override void Up()
        {
            Sql("insert into MembershipTypes ( signupFee,duration,discount) values (0,0,0)");
            Sql("insert into MembershipTypes ( signupFee,duration,discount) values (20,1,10)");
            Sql("insert into MembershipTypes ( signupFee,duration,discount) values (30,6,30)");
            Sql("insert into MembershipTypes ( signupFee,duration,discount) values (100,12,50)");

        }
        
        public override void Down()
        {
        }
    }
}

namespace BookRentalStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedingPackage : DbMigration
    {
        public override void Up()
        {
          
            Sql("Update MembershipTypes set package='pay_as_you_go' where id= 1 ");
            Sql("Update MembershipTypes set package='Monthly' where id= 2 ");
            Sql("Update MembershipTypes set package='Half_yearly' where id= 3 ");
            Sql("Update MembershipTypes set package='Yearly' where id= 4 ");


        }
        
        public override void Down()
        {
        }
    }
}

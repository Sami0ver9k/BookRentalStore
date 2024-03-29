namespace BookRentalStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateBooks1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        genre = c.String(),
                        author = c.String(),
                        price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Books");
        }
    }
}

namespace BookRentalStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateBooks2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            AddColumn("dbo.Books", "genre_id", c => c.Int());
            CreateIndex("dbo.Books", "genre_id");
            AddForeignKey("dbo.Books", "genre_id", "dbo.Genres", "id");
            DropColumn("dbo.Books", "genre");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "genre", c => c.String());
            DropForeignKey("dbo.Books", "genre_id", "dbo.Genres");
            DropIndex("dbo.Books", new[] { "genre_id" });
            DropColumn("dbo.Books", "genre_id");
            DropTable("dbo.Genres");
        }
    }
}

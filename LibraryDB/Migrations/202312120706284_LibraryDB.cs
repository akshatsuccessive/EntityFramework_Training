namespace EF_Exercise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LibraryDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        AuthorId = c.Int(nullable: false, identity: true),
                        AuthorName = c.String(),
                    })
                .PrimaryKey(t => t.AuthorId);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        BookId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        BookAuthor_AuthorId = c.Int(),
                        Person_PersonId = c.Int(),
                    })
                .PrimaryKey(t => t.BookId)
                .ForeignKey("dbo.Authors", t => t.BookAuthor_AuthorId)
                .ForeignKey("dbo.People", t => t.Person_PersonId)
                .Index(t => t.BookAuthor_AuthorId)
                .Index(t => t.Person_PersonId);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonId = c.Int(nullable: false, identity: true),
                        PersonName = c.String(),
                    })
                .PrimaryKey(t => t.PersonId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "Person_PersonId", "dbo.People");
            DropForeignKey("dbo.Books", "BookAuthor_AuthorId", "dbo.Authors");
            DropIndex("dbo.Books", new[] { "Person_PersonId" });
            DropIndex("dbo.Books", new[] { "BookAuthor_AuthorId" });
            DropTable("dbo.People");
            DropTable("dbo.Books");
            DropTable("dbo.Authors");
        }
    }
}

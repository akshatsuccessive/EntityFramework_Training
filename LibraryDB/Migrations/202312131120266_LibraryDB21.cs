namespace EF_Exercise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LibraryDB21 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonId = c.Int(nullable: false, identity: true),
                        PersonName = c.String(),
                    })
                .PrimaryKey(t => t.PersonId);
            
            AddColumn("dbo.Books", "PersonId", c => c.Int(nullable: false));
            CreateIndex("dbo.Books", "PersonId");
            AddForeignKey("dbo.Books", "PersonId", "dbo.People", "PersonId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "PersonId", "dbo.People");
            DropIndex("dbo.Books", new[] { "PersonId" });
            DropColumn("dbo.Books", "PersonId");
            DropTable("dbo.People");
        }
    }
}

namespace EF_Exercise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LibraryDB2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.People", "BookId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.People", "BookId", c => c.Int(nullable: false));
        }
    }
}

namespace EF_Exercise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LibraryDB1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "BookId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "BookId");
        }
    }
}

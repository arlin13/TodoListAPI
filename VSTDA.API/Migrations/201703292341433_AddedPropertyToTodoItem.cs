namespace VSTDA.API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPropertyToTodoItem : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TodoItems", "IsDone", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TodoItems", "IsDone");
        }
    }
}

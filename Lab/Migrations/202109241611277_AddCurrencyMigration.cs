namespace Lab.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCurrencyMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Currency", c => c.String());
            AlterColumn("dbo.Users", "Money", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Money", c => c.String());
            DropColumn("dbo.Users", "Currency");
        }
    }
}

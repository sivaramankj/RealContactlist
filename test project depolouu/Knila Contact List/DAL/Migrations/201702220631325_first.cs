namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contacts", "Phone", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Contacts", "LastName", c => c.String(nullable: true, maxLength: 50));
            AlterColumn("dbo.Contacts", "Email", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Contacts", "Street", c => c.String(nullable: true, maxLength: 50));
            AlterColumn("dbo.Contacts", "City", c => c.String(nullable: true, maxLength: 50));
            AlterColumn("dbo.Contacts", "State", c => c.String(nullable: true, maxLength: 100));
            AlterColumn("dbo.Contacts", "Zip", c => c.String(nullable: true, maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contacts", "Zip", c => c.String(maxLength: 10));
            AlterColumn("dbo.Contacts", "State", c => c.String(maxLength: 100));
            AlterColumn("dbo.Contacts", "City", c => c.String(maxLength: 50));
            AlterColumn("dbo.Contacts", "Street", c => c.String(maxLength: 50));
            AlterColumn("dbo.Contacts", "Email", c => c.String(maxLength: 100));
            AlterColumn("dbo.Contacts", "LastName", c => c.String(maxLength: 50));
            DropColumn("dbo.Contacts", "Phone");
        }
    }
}

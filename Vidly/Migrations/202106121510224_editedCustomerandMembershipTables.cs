namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editedCustomerandMembershipTables : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "MembershipTypeID", "dbo.MembershipTypes");
            DropIndex("dbo.Customers", new[] { "MembershipTypeID" });
            DropPrimaryKey("dbo.MembershipTypes");
            AddColumn("dbo.Customers", "FullName", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "MembershipTypeID", c => c.Byte(nullable: false));
            AlterColumn("dbo.MembershipTypes", "Id", c => c.Byte(nullable: false));
            AddPrimaryKey("dbo.MembershipTypes", "Id");
            CreateIndex("dbo.Customers", "MembershipTypeID");
            AddForeignKey("dbo.Customers", "MembershipTypeID", "dbo.MembershipTypes", "Id", cascadeDelete: true);
            DropColumn("dbo.Customers", "FirstName");
            DropColumn("dbo.Customers", "LasttName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "LasttName", c => c.String());
            AddColumn("dbo.Customers", "FirstName", c => c.String());
            DropForeignKey("dbo.Customers", "MembershipTypeID", "dbo.MembershipTypes");
            DropIndex("dbo.Customers", new[] { "MembershipTypeID" });
            DropPrimaryKey("dbo.MembershipTypes");
            AlterColumn("dbo.MembershipTypes", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Customers", "MembershipTypeID", c => c.Int(nullable: false));
            DropColumn("dbo.Customers", "FullName");
            AddPrimaryKey("dbo.MembershipTypes", "Id");
            CreateIndex("dbo.Customers", "MembershipTypeID");
            AddForeignKey("dbo.Customers", "MembershipTypeID", "dbo.MembershipTypes", "Id", cascadeDelete: true);
        }
    }
}

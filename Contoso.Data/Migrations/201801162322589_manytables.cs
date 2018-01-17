namespace Contoso.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class manytables : DbMigration
    {/// <summary>
    /// //
    /// </summary>
        public override void Up()
        {
            DropForeignKey("dbo.Enrollments", "StudentId", "dbo.Student");
            DropPrimaryKey("dbo.Student");
            AddColumn("dbo.Courses", "Credit", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Student", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Student", "Id");
            CreateIndex("dbo.Student", "Id");
            AddForeignKey("dbo.Student", "Id", "dbo.People", "Id");
            AddForeignKey("dbo.Enrollments", "StudentId", "dbo.Student", "Id");
            DropColumn("dbo.Student", "CreateDate");
            DropColumn("dbo.Student", "UpdatedDate");
            DropColumn("dbo.Student", "CreatedBy");
            DropColumn("dbo.Student", "UpdatedBy");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Student", "UpdatedBy", c => c.String());
            AddColumn("dbo.Student", "CreatedBy", c => c.String());
            AddColumn("dbo.Student", "UpdatedDate", c => c.DateTime());
            AddColumn("dbo.Student", "CreateDate", c => c.DateTime());
            DropForeignKey("dbo.Enrollments", "StudentId", "dbo.Student");
            DropForeignKey("dbo.Student", "Id", "dbo.People");
            DropIndex("dbo.Student", new[] { "Id" });
            DropPrimaryKey("dbo.Student");
            AlterColumn("dbo.Student", "Id", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.Courses", "Credit");
            AddPrimaryKey("dbo.Student", "Id");
            AddForeignKey("dbo.Enrollments", "StudentId", "dbo.Student", "Id", cascadeDelete: true);
        }
    }
}

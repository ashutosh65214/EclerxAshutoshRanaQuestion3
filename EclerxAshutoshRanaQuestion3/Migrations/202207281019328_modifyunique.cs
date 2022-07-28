namespace EclerxAshutoshRanaQuestion3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifyunique : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Companies", "MobileNo", c => c.String(nullable: false, maxLength: 12, unicode: false));
            AlterColumn("dbo.Companies", "Email", c => c.String(nullable: false, maxLength: 100, unicode: false));
            CreateIndex("dbo.Companies", "MobileNo", unique: true, name: "Ix_MobileNo");
            CreateIndex("dbo.Companies", "Email", unique: true, name: "Ix_Email");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Companies", "Ix_Email");
            DropIndex("dbo.Companies", "Ix_MobileNo");
            AlterColumn("dbo.Companies", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Companies", "MobileNo", c => c.String(nullable: false));
        }
    }
}

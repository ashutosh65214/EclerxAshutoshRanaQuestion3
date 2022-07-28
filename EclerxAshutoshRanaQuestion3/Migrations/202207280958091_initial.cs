namespace EclerxAshutoshRanaQuestion3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        SupplierId = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(nullable: false),
                        ContactName = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        PinCode = c.String(nullable: false),
                        MobileNo = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        CreatedDate = c.DateTime(nullable: false, defaultValueSql: "Getdate()"),
                        ModdifiedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.SupplierId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Companies");
        }
    }
}

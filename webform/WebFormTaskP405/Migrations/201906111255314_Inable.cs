namespace WebFormTaskP405.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        Surname = c.String(nullable: false, maxLength: 30),
                        Email = c.String(nullable: false, maxLength: 40, unicode: false),
                        Password = c.String(nullable: false, maxLength: 16, unicode: false),
                        RegisterDate = c.DateTime(nullable: false, storeType: "smalldatetime"),
                        LastLoggedDate = c.DateTime(storeType: "smalldatetime"),
                        IsLockedOut = c.Boolean(nullable: false),
                        LockedDate = c.DateTime(storeType: "smalldatetime"),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.People");
        }
    }
}

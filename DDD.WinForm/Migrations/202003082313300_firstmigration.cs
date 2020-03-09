namespace DDD.WinForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstmigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        RunDist = c.Single(nullable: false),
                        FirstRegist = c.DateTime(nullable: false),
                        EngineType = c.Int(nullable: false),
                        Inspection = c.Int(nullable: false),
                        IsRepair = c.Int(nullable: false),
                        Maker_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Makers", t => t.Maker_Id)
                .Index(t => t.Maker_Id);
            
            CreateTable(
                "dbo.Makers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "Maker_Id", "dbo.Makers");
            DropIndex("dbo.Cars", new[] { "Maker_Id" });
            DropTable("dbo.Makers");
            DropTable("dbo.Cars");
        }
    }
}

namespace DDD.WinForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletemaker : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cars", "Maker_Id", "dbo.Makers");
            DropIndex("dbo.Cars", new[] { "Maker_Id" });
            DropColumn("dbo.Cars", "Maker_Id");
            DropTable("dbo.Makers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Makers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Cars", "Maker_Id", c => c.Int());
            CreateIndex("dbo.Cars", "Maker_Id");
            AddForeignKey("dbo.Cars", "Maker_Id", "dbo.Makers", "Id");
        }
    }
}

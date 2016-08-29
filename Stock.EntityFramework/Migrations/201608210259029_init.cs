namespace Stock.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TblArea",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        Name = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TblIndustry",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TblStockBaseInfo",
                c => new
                    {
                        Code = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        Name = c.String(unicode: false),
                        IndustryId = c.Int(nullable: false),
                        AreaId = c.String(maxLength: 128, storeType: "nvarchar"),
                        DateOfIPO = c.DateTime(nullable: false, precision: 0),
                        Id = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Code)
                .ForeignKey("dbo.TblArea", t => t.AreaId)
                .ForeignKey("dbo.TblIndustry", t => t.IndustryId, cascadeDelete: true)
                .Index(t => t.IndustryId)
                .Index(t => t.AreaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TblStockBaseInfo", "IndustryId", "dbo.TblIndustry");
            DropForeignKey("dbo.TblStockBaseInfo", "AreaId", "dbo.TblArea");
            DropIndex("dbo.TblStockBaseInfo", new[] { "AreaId" });
            DropIndex("dbo.TblStockBaseInfo", new[] { "IndustryId" });
            DropTable("dbo.TblStockBaseInfo");
            DropTable("dbo.TblIndustry");
            DropTable("dbo.TblArea");
        }
    }
}

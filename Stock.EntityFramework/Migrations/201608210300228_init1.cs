namespace Stock.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TblIndustry", "Name", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TblIndustry", "Name");
        }
    }
}

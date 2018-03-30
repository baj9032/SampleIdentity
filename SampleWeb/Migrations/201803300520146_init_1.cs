namespace SampleWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init_1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Authors", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Authors", "Name", c => c.String());
        }
    }
}

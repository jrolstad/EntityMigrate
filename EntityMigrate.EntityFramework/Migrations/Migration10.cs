namespace EntityMigrate.EntityFramework.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class Migration10 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TradeSubmissions",
                c => new
                    {
                        TradeSubmissionId = c.Long(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.TradeSubmissionId);
            
            CreateTable(
                "dbo.TradeOrders",
                c => new
                    {
                        TradeOrderId = c.Long(nullable: false, identity: true),
                        TradeSubmissionId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.TradeOrderId)
                .ForeignKey("dbo.TradeSubmissions", t => t.TradeSubmissionId, cascadeDelete: true)
                .Index(t => t.TradeSubmissionId);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.TradeOrders", new[] { "TradeSubmissionId" });
            DropForeignKey("dbo.TradeOrders", "TradeSubmissionId", "dbo.TradeSubmissions");
            DropTable("dbo.TradeOrders");
            DropTable("dbo.TradeSubmissions");
        }
    }
}

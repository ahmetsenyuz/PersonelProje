namespace PersonelProje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstMig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sehir",
                c => new
                    {
                        SehirId = c.Int(nullable: false, identity: true),
                        SehirAd = c.String(),
                    })
                .PrimaryKey(t => t.SehirId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Sehir");
        }
    }
}

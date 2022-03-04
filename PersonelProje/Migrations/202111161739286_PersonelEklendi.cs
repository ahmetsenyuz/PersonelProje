namespace PersonelProje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PersonelEklendi : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Personel",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        SehirId = c.Int(nullable: false),
                        Soyad = c.String(),
                        Maas = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sehir", t => t.SehirId, cascadeDelete: true)
                .Index(t => t.SehirId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Personel", "SehirId", "dbo.Sehir");
            DropIndex("dbo.Personel", new[] { "SehirId" });
            DropTable("dbo.Personel");
        }
    }
}

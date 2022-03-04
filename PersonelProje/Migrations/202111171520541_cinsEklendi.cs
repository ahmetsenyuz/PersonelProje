namespace PersonelProje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cinsEklendi : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Personel", "Cins", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Personel", "Cins");
        }
    }
}

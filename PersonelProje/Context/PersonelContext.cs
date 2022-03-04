using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web.DynamicData;

namespace PersonelProje.Context
{
    //1 Enable migration
    //2 Add-Migration isim
    //3 Update-database
    //4 Gerekirse 2.Adýma git 
    public class PersonelContext : DbContext
    {
        //tablo adýnýn sonuna 's' eklenmemesini saðlýyor.
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        //-----------------------------------------------------
        // Your context has been configured to use a 'PersonelContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'PersonelProje.Context.PersonelContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'PersonelContext' 
        // connection string in the application configuration file.
        public PersonelContext()
            : base("name=Connection")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Sehir> Sehir { get; set; }
        public virtual DbSet<Personel> Personel { get; set; }
    }
    public class Sehir//claslar tabloyu temsil ediyor.
    {
        public Sehir()
        {
            Personeller = new HashSet<Personel>();//hashset yerine list de yazýlabilirdi ayný bok.
        }
        public int SehirId { get; set; }
        public string SehirAd { get; set; }
        public virtual HashSet<Personel> Personeller { get; set; }//bir þehirde birden fazla personel olabilir.Ýki tablo arasý baðlantý
    }
    public class Personel//claslar tabloyu temsil ediyor.
    {
        [Key]//içinde id olaný otomatik primary key atar. yoksa bötle yazmamýz lazým.
        public int Id { get; set; }
        public string Ad { get; set; }
        public int SehirId { get; set; }
        public string Soyad { get; set; }
        public decimal Maas { get; set; }
        public string Cins { get; set; }
        [ForeignKey("SehirId")]
        public virtual Sehir Sehir { get; set; }//bir personelin bir þehri vardýr.//iki tablo arasý baðlantý
    }
}
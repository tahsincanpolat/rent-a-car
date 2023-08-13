namespace RentACar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Arabalars",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Plaka = c.String(nullable: false),
                        Marka = c.String(nullable: false),
                        Model = c.String(nullable: false),
                        AracTipi = c.String(nullable: false),
                        Vites = c.String(nullable: false),
                        YakitTipi = c.String(nullable: false),
                        ImageUrl = c.String(),
                        Fiyat = c.Double(nullable: false),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        AktifMi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Kiralamas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ArabaID = c.Int(nullable: false),
                        YoneticiID = c.String(),
                        AlisTarihi = c.DateTime(nullable: false),
                        TeslimTarihi = c.DateTime(nullable: false),
                        KiralamaSuresi = c.Int(),
                        FaturaTutari = c.Double(nullable: false),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        AktifMi = c.Boolean(nullable: false),
                        Arabalar_ID = c.Int(),
                        Yoneticiler_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Arabalars", t => t.Arabalar_ID)
                .ForeignKey("dbo.Yoneticilers", t => t.Yoneticiler_ID)
                .Index(t => t.Arabalar_ID)
                .Index(t => t.Yoneticiler_ID);
            
            CreateTable(
                "dbo.Yoneticilers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Adi = c.String(nullable: false),
                        Soyadi = c.String(nullable: false),
                        TC = c.String(nullable: false),
                        EhliyetNo = c.String(nullable: false),
                        Telefon = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Adres = c.String(nullable: false),
                        Sifre = c.String(nullable: false),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        AktifMi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Kiralamas", "Yoneticiler_ID", "dbo.Yoneticilers");
            DropForeignKey("dbo.Kiralamas", "Arabalar_ID", "dbo.Arabalars");
            DropIndex("dbo.Kiralamas", new[] { "Yoneticiler_ID" });
            DropIndex("dbo.Kiralamas", new[] { "Arabalar_ID" });
            DropTable("dbo.Yoneticilers");
            DropTable("dbo.Kiralamas");
            DropTable("dbo.Arabalars");
        }
    }
}

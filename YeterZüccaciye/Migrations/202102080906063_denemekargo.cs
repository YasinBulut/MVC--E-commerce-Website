namespace YeterZüccaciye.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class denemekargo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CargoDetays",
                c => new
                    {
                        CargoExplanationID = c.String(nullable: false, maxLength: 128),
                        CargoExplanation = c.String(maxLength: 250, unicode: false),
                        TakipKodu = c.String(maxLength: 10, unicode: false),
                        Personel = c.String(maxLength: 20, unicode: false),
                        Alici = c.String(maxLength: 20, unicode: false),
                        Tarih = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CargoExplanationID);
            
            CreateTable(
                "dbo.CargoTakips",
                c => new
                    {
                        CargoTakipID = c.Int(nullable: false, identity: true),
                        TakipKodu = c.String(maxLength: 10, unicode: false),
                        Açıklama = c.String(maxLength: 100, unicode: false),
                        TarihZaman = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CargoTakipID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CargoTakips");
            DropTable("dbo.CargoDetays");
        }
    }
}

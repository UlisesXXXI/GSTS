namespace GSTS.BaseDeDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class primera : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Gasto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TipoGastoId = c.Int(),
                        Descripcion = c.String(nullable: false, maxLength: 100),
                        Fecha = c.DateTime(nullable: false),
                        Importe = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TipoGasto", t => t.TipoGastoId)
                .Index(t => t.TipoGastoId);
            
            CreateTable(
                "dbo.TipoGasto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Gasto", "TipoGastoId", "dbo.TipoGasto");
            DropIndex("dbo.Gasto", new[] { "TipoGastoId" });
            DropTable("dbo.TipoGasto");
            DropTable("dbo.Gasto");
        }
    }
}

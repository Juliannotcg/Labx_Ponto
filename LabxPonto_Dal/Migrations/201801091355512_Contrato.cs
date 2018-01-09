namespace LabxPonto_Dao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Contrato : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.FunFuncionario", "Fun_ConId", "dbo.ConContrato");
            DropIndex("dbo.FunFuncionario", new[] { "Fun_ConId" });
            AddColumn("dbo.FunFuncionario", "FunDataAdmissao", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AddColumn("dbo.FunFuncionario", "FunDataRecisao", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AddColumn("dbo.FunFuncionario", "FunMotivoRecisao", c => c.String(maxLength: 100, unicode: false));
            AddColumn("dbo.FunFuncionario", "FunNumeroFolha", c => c.String(maxLength: 100, unicode: false));
            DropColumn("dbo.FunFuncionario", "Fun_ConId");
            DropTable("dbo.ConContrato");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ConContrato",
                c => new
                    {
                        ConId = c.Int(nullable: false, identity: true),
                        ConNumeroFolha = c.Int(nullable: false),
                        ConDataAdmissao = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        ConDataRecisao = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        ConMotivoRecisao = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.ConId);
            
            AddColumn("dbo.FunFuncionario", "Fun_ConId", c => c.Int());
            DropColumn("dbo.FunFuncionario", "FunNumeroFolha");
            DropColumn("dbo.FunFuncionario", "FunMotivoRecisao");
            DropColumn("dbo.FunFuncionario", "FunDataRecisao");
            DropColumn("dbo.FunFuncionario", "FunDataAdmissao");
            CreateIndex("dbo.FunFuncionario", "Fun_ConId");
            AddForeignKey("dbo.FunFuncionario", "Fun_ConId", "dbo.ConContrato", "ConId");
        }
    }
}

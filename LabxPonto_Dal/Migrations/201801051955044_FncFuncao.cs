namespace LabxPonto_Dao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FncFuncao : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.FunFuncionario", "Fun_DepId", "dbo.DepDepartamento");
            DropIndex("dbo.FunFuncionario", new[] { "Fun_DepId" });
            DropColumn("dbo.FunFuncionario", "Fun_DepId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.FunFuncionario", "Fun_DepId", c => c.Int());
            CreateIndex("dbo.FunFuncionario", "Fun_DepId");
            AddForeignKey("dbo.FunFuncionario", "Fun_DepId", "dbo.DepDepartamento", "DepId");
        }
    }
}

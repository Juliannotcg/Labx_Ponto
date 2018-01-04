namespace LabxPonto_Dao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DepDepartamento_FncFuncao : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FncFuncao", "Fnc_DepId", c => c.Int());
            CreateIndex("dbo.FncFuncao", "Fnc_DepId");
            AddForeignKey("dbo.FncFuncao", "Fnc_DepId", "dbo.DepDepartamento", "DepId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FncFuncao", "Fnc_DepId", "dbo.DepDepartamento");
            DropIndex("dbo.FncFuncao", new[] { "Fnc_DepId" });
            DropColumn("dbo.FncFuncao", "Fnc_DepId");
        }
    }
}

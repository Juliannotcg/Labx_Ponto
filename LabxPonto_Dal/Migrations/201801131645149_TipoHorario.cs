namespace LabxPonto_Dao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TipoHorario : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.HorHorarioExpediente", new[] { "Funcionario_Id1" });
            RenameColumn(table: "dbo.FunFuncionario", name: "Funcionario_Id1", newName: "Horario_Id");
            CreateIndex("dbo.FunFuncionario", "Horario_Id");
            DropColumn("dbo.HorHorarioExpediente", "Funcionario_Id1");
        }
        
        public override void Down()
        {
            AddColumn("dbo.HorHorarioExpediente", "Funcionario_Id1", c => c.Int());
            DropIndex("dbo.FunFuncionario", new[] { "Horario_Id" });
            RenameColumn(table: "dbo.FunFuncionario", name: "Horario_Id", newName: "Funcionario_Id1");
            CreateIndex("dbo.HorHorarioExpediente", "Funcionario_Id1");
        }
    }
}

namespace LabxPonto_Dao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HorExpediente : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.HorHorarioExpediente", name: "HorDataExpediente", newName: "HorData");
            AddColumn("dbo.HorHorarioExpediente", "HorEntrada", c => c.DateTime(nullable: false));
            AddColumn("dbo.HorHorarioExpediente", "HorSaida", c => c.DateTime(nullable: false));
            DropColumn("dbo.HorHorarioExpediente", "HorDescricao");
            DropColumn("dbo.HorHorarioExpediente", "HorInicioTurno");
            DropColumn("dbo.HorHorarioExpediente", "HorFimTurno");
            DropColumn("dbo.HorHorarioExpediente", "HorInicioAlmoco");
            DropColumn("dbo.HorHorarioExpediente", "HorFimAlmoco");
            DropColumn("dbo.HorHorarioExpediente", "HorInicioAbono");
            DropColumn("dbo.HorHorarioExpediente", "HorFimAbono");
            DropColumn("dbo.HorHorarioExpediente", "HorJustificativaAbono");
        }
        
        public override void Down()
        {
            AddColumn("dbo.HorHorarioExpediente", "HorJustificativaAbono", c => c.String(maxLength: 100, unicode: false));
            AddColumn("dbo.HorHorarioExpediente", "HorFimAbono", c => c.DateTime(nullable: false));
            AddColumn("dbo.HorHorarioExpediente", "HorInicioAbono", c => c.DateTime(nullable: false));
            AddColumn("dbo.HorHorarioExpediente", "HorFimAlmoco", c => c.DateTime(nullable: false));
            AddColumn("dbo.HorHorarioExpediente", "HorInicioAlmoco", c => c.DateTime(nullable: false));
            AddColumn("dbo.HorHorarioExpediente", "HorFimTurno", c => c.DateTime(nullable: false));
            AddColumn("dbo.HorHorarioExpediente", "HorInicioTurno", c => c.DateTime(nullable: false));
            AddColumn("dbo.HorHorarioExpediente", "HorDescricao", c => c.String(maxLength: 100, unicode: false));
            DropColumn("dbo.HorHorarioExpediente", "HorSaida");
            DropColumn("dbo.HorHorarioExpediente", "HorEntrada");
            RenameColumn(table: "dbo.HorHorarioExpediente", name: "HorData", newName: "HorDataExpediente");
        }
    }
}

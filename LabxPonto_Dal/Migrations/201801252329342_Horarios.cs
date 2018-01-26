namespace LabxPonto_Dao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Horarios : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.HorHorarioExpediente", "HorEntrada", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.HorHorarioExpediente", "HorSaida", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.HorHorarioExpediente", "HorData", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.HorHorarioExpediente", "HorData", c => c.DateTime(nullable: false));
            AlterColumn("dbo.HorHorarioExpediente", "HorSaida", c => c.DateTime(nullable: false));
            AlterColumn("dbo.HorHorarioExpediente", "HorEntrada", c => c.DateTime(nullable: false));
        }
    }
}

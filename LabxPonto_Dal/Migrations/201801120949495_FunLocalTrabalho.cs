namespace LabxPonto_Dao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FunLocalTrabalho : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FunFuncionario", "FunLocalTrabalho", c => c.String(maxLength: 100, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.FunFuncionario", "FunLocalTrabalho");
        }
    }
}

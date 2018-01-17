namespace LabxPonto_Dao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FuncionarioDigital : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.FunFuncionario", "FunDigital", c => c.Binary());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.FunFuncionario", "FunDigital", c => c.String(maxLength: 100, unicode: false));
        }
    }
}

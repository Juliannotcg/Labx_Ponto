namespace LabxPonto_Dao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DateTime2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ConContrato", "ConDataAdmissao", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.FunFuncionario", "FunDataNascimento", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.FunFuncionario", "FunDataNascimento", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ConContrato", "ConDataAdmissao", c => c.DateTime(nullable: false));
        }
    }
}

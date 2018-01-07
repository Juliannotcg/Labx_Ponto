namespace LabxPonto_Dao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmpEmpresa : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EmpEmpresa", "EmpNomeResponsavel", c => c.String(maxLength: 100, unicode: false));
            AddColumn("dbo.EmpEmpresa", "EmpCargoResponsavel", c => c.String(maxLength: 100, unicode: false));
            AddColumn("dbo.EmpEmpresa", "EmpEmailResponsavel", c => c.String(maxLength: 100, unicode: false));
            AddColumn("dbo.EmpEmpresa", "EmpInscricao", c => c.String(maxLength: 100, unicode: false));
            AddColumn("dbo.EmpEmpresa", "EmpNumeroFolha", c => c.Int(nullable: false));
            AddColumn("dbo.EmpEmpresa", "EmpCEI", c => c.String(maxLength: 100, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.EmpEmpresa", "EmpCEI");
            DropColumn("dbo.EmpEmpresa", "EmpNumeroFolha");
            DropColumn("dbo.EmpEmpresa", "EmpInscricao");
            DropColumn("dbo.EmpEmpresa", "EmpEmailResponsavel");
            DropColumn("dbo.EmpEmpresa", "EmpCargoResponsavel");
            DropColumn("dbo.EmpEmpresa", "EmpNomeResponsavel");
        }
    }
}

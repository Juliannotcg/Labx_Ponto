namespace LabxPonto_Dao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ImaImagem : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ImaImagem",
                c => new
                    {
                        ImaId = c.Int(nullable: false, identity: true),
                        ImaArquivo = c.Binary(),
                    })
                .PrimaryKey(t => t.ImaId);
            
            AddColumn("dbo.EmpEmpresa", "Emp_ImaId", c => c.Int());
            AddColumn("dbo.FunFuncionario", "Fun_ImaId", c => c.Int());
            CreateIndex("dbo.EmpEmpresa", "Emp_ImaId");
            CreateIndex("dbo.FunFuncionario", "Fun_ImaId");
            AddForeignKey("dbo.FunFuncionario", "Fun_ImaId", "dbo.ImaImagem", "ImaId");
            AddForeignKey("dbo.EmpEmpresa", "Emp_ImaId", "dbo.ImaImagem", "ImaId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmpEmpresa", "Emp_ImaId", "dbo.ImaImagem");
            DropForeignKey("dbo.FunFuncionario", "Fun_ImaId", "dbo.ImaImagem");
            DropIndex("dbo.FunFuncionario", new[] { "Fun_ImaId" });
            DropIndex("dbo.EmpEmpresa", new[] { "Emp_ImaId" });
            DropColumn("dbo.FunFuncionario", "Fun_ImaId");
            DropColumn("dbo.EmpEmpresa", "Emp_ImaId");
            DropTable("dbo.ImaImagem");
        }
    }
}

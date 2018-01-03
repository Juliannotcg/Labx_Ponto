namespace LabxPonto_Dao.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class CriacaoBanco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ConContrato",
                c => new
                    {
                        ConId = c.Int(nullable: false, identity: true),
                        ConNumeroFolha = c.Int(nullable: false),
                        ConDataAdmissao = c.DateTime(nullable: false),
                        ConDataRecisao = c.DateTime(nullable: false),
                        ConMotivoRecisao = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.ConId);
            
            CreateTable(
                "dbo.DepDepartamento",
                c => new
                    {
                        DepId = c.Int(nullable: false, identity: true),
                        DepNomeDepartamento = c.String(maxLength: 100, unicode: false),
                        DepDescricao = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.DepId);
            
            CreateTable(
                "dbo.EmpEmpresa",
                c => new
                    {
                        EmpId = c.Int(nullable: false, identity: true),
                        EmpNomeFantasia = c.String(maxLength: 100, unicode: false),
                        EmpRazaoSocial = c.String(maxLength: 100, unicode: false),
                        EmpCNPJ = c.String(maxLength: 100, unicode: false),
                        Emp_EndId = c.Int(),
                    })
                .PrimaryKey(t => t.EmpId)
                .ForeignKey("dbo.EndEndereco", t => t.Emp_EndId)
                .Index(t => t.Emp_EndId);
            
            CreateTable(
                "dbo.EndEndereco",
                c => new
                    {
                        EndId = c.Int(nullable: false, identity: true),
                        EndLogradouro = c.String(maxLength: 100, unicode: false),
                        EndRua = c.String(maxLength: 100, unicode: false),
                        EndEstado = c.String(maxLength: 100, unicode: false),
                        EndCidade = c.String(maxLength: 100, unicode: false),
                        EndBairro = c.String(maxLength: 100, unicode: false),
                        EndComplemento = c.String(maxLength: 100, unicode: false),
                        EndNumero = c.Int(nullable: false),
                        EndCep = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EndId);
            
            CreateTable(
                "dbo.FunFuncionario",
                c => new
                    {
                        FunId = c.Int(nullable: false, identity: true),
                        FunNome = c.String(maxLength: 100, unicode: false),
                        FunSobrenome = c.String(maxLength: 100, unicode: false),
                        FunRG = c.String(maxLength: 100, unicode: false),
                        FunCPF = c.String(maxLength: 100, unicode: false),
                        FunDigital = c.String(maxLength: 100, unicode: false),
                        FunEstadoCivil = c.String(maxLength: 100, unicode: false),
                        FunTelefone = c.String(maxLength: 100, unicode: false),
                        FunNomePai = c.String(maxLength: 100, unicode: false),
                        FunNomeMae = c.String(maxLength: 100, unicode: false),
                        FunDataNascimento = c.DateTime(nullable: false),
                        Fun_ConId = c.Int(),
                        Fun_DepId = c.Int(),
                        Fun_EmpId = c.Int(),
                        Fun_EndId = c.Int(),
                        Fun_FncId = c.Int(),
                        Empresa_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.FunId)
                .ForeignKey("dbo.ConContrato", t => t.Fun_ConId)
                .ForeignKey("dbo.DepDepartamento", t => t.Fun_DepId)
                .ForeignKey("dbo.EmpEmpresa", t => t.Fun_EmpId)
                .ForeignKey("dbo.EndEndereco", t => t.Fun_EndId)
                .ForeignKey("dbo.FncFuncao", t => t.Fun_FncId)
                .ForeignKey("dbo.EmpEmpresa", t => t.Empresa_Id1)
                .Index(t => t.Fun_ConId)
                .Index(t => t.Fun_DepId)
                .Index(t => t.Fun_EmpId)
                .Index(t => t.Fun_EndId)
                .Index(t => t.Fun_FncId)
                .Index(t => t.Empresa_Id1);
            
            CreateTable(
                "dbo.FncFuncao",
                c => new
                    {
                        FncId = c.Int(nullable: false, identity: true),
                        FncNome = c.String(maxLength: 100, unicode: false),
                        FncDescricao = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.FncId);
            
            CreateTable(
                "dbo.HorHorarioExpediente",
                c => new
                    {
                        HorId = c.Int(nullable: false, identity: true),
                        HorDescricao = c.String(maxLength: 100, unicode: false),
                        HorInicioTurno = c.DateTime(nullable: false),
                        HorFimTurno = c.DateTime(nullable: false),
                        HorInicioAlmoco = c.DateTime(nullable: false),
                        HorFimAlmoco = c.DateTime(nullable: false),
                        HorInicioAbono = c.DateTime(nullable: false),
                        HorFimAbono = c.DateTime(nullable: false),
                        HorJustificativaAbono = c.String(maxLength: 100, unicode: false),
                        HorDataExpediente = c.DateTime(nullable: false),
                        Hor_FunId = c.Int(),
                        Funcionario_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.HorId)
                .ForeignKey("dbo.FunFuncionario", t => t.Hor_FunId)
                .ForeignKey("dbo.FunFuncionario", t => t.Funcionario_Id1)
                .Index(t => t.Hor_FunId)
                .Index(t => t.Funcionario_Id1);
            
            CreateTable(
                "dbo.UsuUsuario",
                c => new
                    {
                        UsuId = c.Int(nullable: false, identity: true),
                        UsuLogin = c.String(maxLength: 100, unicode: false),
                        UsuSenha = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.UsuId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FunFuncionario", "Empresa_Id1", "dbo.EmpEmpresa");
            DropForeignKey("dbo.HorHorarioExpediente", "Funcionario_Id1", "dbo.FunFuncionario");
            DropForeignKey("dbo.HorHorarioExpediente", "Hor_FunId", "dbo.FunFuncionario");
            DropForeignKey("dbo.FunFuncionario", "Fun_FncId", "dbo.FncFuncao");
            DropForeignKey("dbo.FunFuncionario", "Fun_EndId", "dbo.EndEndereco");
            DropForeignKey("dbo.FunFuncionario", "Fun_EmpId", "dbo.EmpEmpresa");
            DropForeignKey("dbo.FunFuncionario", "Fun_DepId", "dbo.DepDepartamento");
            DropForeignKey("dbo.FunFuncionario", "Fun_ConId", "dbo.ConContrato");
            DropForeignKey("dbo.EmpEmpresa", "Emp_EndId", "dbo.EndEndereco");
            DropIndex("dbo.HorHorarioExpediente", new[] { "Funcionario_Id1" });
            DropIndex("dbo.HorHorarioExpediente", new[] { "Hor_FunId" });
            DropIndex("dbo.FunFuncionario", new[] { "Empresa_Id1" });
            DropIndex("dbo.FunFuncionario", new[] { "Fun_FncId" });
            DropIndex("dbo.FunFuncionario", new[] { "Fun_EndId" });
            DropIndex("dbo.FunFuncionario", new[] { "Fun_EmpId" });
            DropIndex("dbo.FunFuncionario", new[] { "Fun_DepId" });
            DropIndex("dbo.FunFuncionario", new[] { "Fun_ConId" });
            DropIndex("dbo.EmpEmpresa", new[] { "Emp_EndId" });
            DropTable("dbo.UsuUsuario");
            DropTable("dbo.HorHorarioExpediente");
            DropTable("dbo.FncFuncao");
            DropTable("dbo.FunFuncionario");
            DropTable("dbo.EndEndereco");
            DropTable("dbo.EmpEmpresa");
            DropTable("dbo.DepDepartamento");
            DropTable("dbo.ConContrato");
        }
    }
}

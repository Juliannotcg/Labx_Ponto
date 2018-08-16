namespace LabxPonto_Dao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataBaseInitial : DbMigration
    {
        public override void Up()
        {
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
                        EmpNomeResponsavel = c.String(maxLength: 100, unicode: false),
                        EmpCargoResponsavel = c.String(maxLength: 100, unicode: false),
                        EmpEmailResponsavel = c.String(maxLength: 100, unicode: false),
                        EmpInscricao = c.String(maxLength: 100, unicode: false),
                        EmpNumeroFolha = c.Int(nullable: false),
                        EmpCEI = c.String(maxLength: 100, unicode: false),
                        Emp_EndId = c.Int(),
                        Emp_ImaId = c.Int(),
                    })
                .PrimaryKey(t => t.EmpId)
                .ForeignKey("dbo.EndEndereco", t => t.Emp_EndId)
                .ForeignKey("dbo.ImaImagem", t => t.Emp_ImaId)
                .Index(t => t.Emp_EndId)
                .Index(t => t.Emp_ImaId);
            
            CreateTable(
                "dbo.EndEndereco",
                c => new
                    {
                        EndId = c.Int(nullable: false, identity: true),
                        EndLogradouro = c.String(maxLength: 100, unicode: false),
                        EndRua = c.String(maxLength: 100, unicode: false),
                        EndEstado = c.String(maxLength: 100, unicode: false),
                        EmpPais = c.String(maxLength: 100, unicode: false),
                        EndCidade = c.String(maxLength: 100, unicode: false),
                        EndBairro = c.String(maxLength: 100, unicode: false),
                        EndComplementoo = c.String(maxLength: 100, unicode: false),
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
                        FunImagemDigital = c.Binary(),
                        ImagemDigital = c.Binary(),
                        FunEstadoCivil = c.String(maxLength: 100, unicode: false),
                        FunTelefone = c.String(maxLength: 100, unicode: false),
                        FunNomePai = c.String(maxLength: 100, unicode: false),
                        FunNomeMae = c.String(maxLength: 100, unicode: false),
                        FunLocalTrabalho = c.String(maxLength: 100, unicode: false),
                        FunDataNascimento = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        FunDataAdmissao = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        FunDataRecisao = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        FunMotivoRecisao = c.String(maxLength: 100, unicode: false),
                        FunNumeroFolha = c.String(maxLength: 100, unicode: false),
                        Fun_EmpId = c.Int(),
                        Fun_EndId = c.Int(),
                        Fun_FncId = c.Int(),
                        Fun_ImaId = c.Int(),
                        Empresa_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.FunId)
                .ForeignKey("dbo.EmpEmpresa", t => t.Fun_EmpId)
                .ForeignKey("dbo.EndEndereco", t => t.Fun_EndId)
                .ForeignKey("dbo.FncFuncao", t => t.Fun_FncId)
                .ForeignKey("dbo.ImaImagem", t => t.Fun_ImaId)
                .ForeignKey("dbo.EmpEmpresa", t => t.Empresa_Id1)
                .Index(t => t.Fun_EmpId)
                .Index(t => t.Fun_EndId)
                .Index(t => t.Fun_FncId)
                .Index(t => t.Fun_ImaId)
                .Index(t => t.Empresa_Id1);
            
            CreateTable(
                "dbo.FncFuncao",
                c => new
                    {
                        FncId = c.Int(nullable: false, identity: true),
                        FncNome = c.String(maxLength: 100, unicode: false),
                        FncDescricao = c.String(maxLength: 100, unicode: false),
                        Fnc_DepId = c.Int(),
                    })
                .PrimaryKey(t => t.FncId)
                .ForeignKey("dbo.DepDepartamento", t => t.Fnc_DepId)
                .Index(t => t.Fnc_DepId);
            
            CreateTable(
                "dbo.ImaImagem",
                c => new
                    {
                        ImaId = c.Int(nullable: false, identity: true),
                        ImaArquivo = c.Binary(),
                    })
                .PrimaryKey(t => t.ImaId);
            
            CreateTable(
                "dbo.HorHorarioExpediente",
                c => new
                    {
                        HorId = c.Int(nullable: false, identity: true),
                        HorEntrada = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        HorSaida = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        HorData = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Hor_FunId = c.Int(),
                    })
                .PrimaryKey(t => t.HorId)
                .ForeignKey("dbo.FunFuncionario", t => t.Hor_FunId)
                .Index(t => t.Hor_FunId);
            
            CreateTable(
                "dbo.UsuUsuario",
                c => new
                    {
                        UsuId = c.Int(nullable: false, identity: true),
                        UsuLogin = c.String(maxLength: 100, unicode: false),
                        UsuSenha = c.String(maxLength: 100, unicode: false),
                        UsuPerfil = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.UsuId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HorHorarioExpediente", "Hor_FunId", "dbo.FunFuncionario");
            DropForeignKey("dbo.EmpEmpresa", "Emp_ImaId", "dbo.ImaImagem");
            DropForeignKey("dbo.FunFuncionario", "Empresa_Id1", "dbo.EmpEmpresa");
            DropForeignKey("dbo.FunFuncionario", "Fun_ImaId", "dbo.ImaImagem");
            DropForeignKey("dbo.FunFuncionario", "Fun_FncId", "dbo.FncFuncao");
            DropForeignKey("dbo.FncFuncao", "Fnc_DepId", "dbo.DepDepartamento");
            DropForeignKey("dbo.FunFuncionario", "Fun_EndId", "dbo.EndEndereco");
            DropForeignKey("dbo.FunFuncionario", "Fun_EmpId", "dbo.EmpEmpresa");
            DropForeignKey("dbo.EmpEmpresa", "Emp_EndId", "dbo.EndEndereco");
            DropIndex("dbo.HorHorarioExpediente", new[] { "Hor_FunId" });
            DropIndex("dbo.FncFuncao", new[] { "Fnc_DepId" });
            DropIndex("dbo.FunFuncionario", new[] { "Empresa_Id1" });
            DropIndex("dbo.FunFuncionario", new[] { "Fun_ImaId" });
            DropIndex("dbo.FunFuncionario", new[] { "Fun_FncId" });
            DropIndex("dbo.FunFuncionario", new[] { "Fun_EndId" });
            DropIndex("dbo.FunFuncionario", new[] { "Fun_EmpId" });
            DropIndex("dbo.EmpEmpresa", new[] { "Emp_ImaId" });
            DropIndex("dbo.EmpEmpresa", new[] { "Emp_EndId" });
            DropTable("dbo.UsuUsuario");
            DropTable("dbo.HorHorarioExpediente");
            DropTable("dbo.ImaImagem");
            DropTable("dbo.FncFuncao");
            DropTable("dbo.FunFuncionario");
            DropTable("dbo.EndEndereco");
            DropTable("dbo.EmpEmpresa");
            DropTable("dbo.DepDepartamento");
        }
    }
}

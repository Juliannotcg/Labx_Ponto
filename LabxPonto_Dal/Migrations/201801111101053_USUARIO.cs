namespace LabxPonto_Dao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class USUARIO : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                 "dbo.UsuUsuario",
                 c => new
                 {
                     UsuId = c.Int(nullable: false, identity: true),
                     UsuPerfil = c.String(),
                     UsuLogin = c.String(),
                     UsuSenha = c.String(),
                 })
                 .PrimaryKey(t => t.UsuId);
        }
        
        public override void Down()
        {
            DropTable("dbo.UsuUsuario");
        }
    }
}

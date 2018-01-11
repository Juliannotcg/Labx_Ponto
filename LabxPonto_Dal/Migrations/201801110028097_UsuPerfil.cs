namespace LabxPonto_Dao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UsuPerfil : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.UsuUsuario", name: "UsuSenha", newName: "UsuPerfil");
            AddColumn("dbo.UsuUsuario", "Perfil", c => c.String(maxLength: 100, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.UsuUsuario", "Perfil");
            RenameColumn(table: "dbo.UsuUsuario", name: "UsuPerfil", newName: "UsuSenha");
        }
    }
}

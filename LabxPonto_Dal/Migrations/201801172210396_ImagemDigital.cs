namespace LabxPonto_Dao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ImagemDigital : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.FunFuncionario", name: "FunDigital", newName: "FunImagemDigital");
            AddColumn("dbo.FunFuncionario", "ImagemDigital", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.FunFuncionario", "ImagemDigital");
            RenameColumn(table: "dbo.FunFuncionario", name: "FunImagemDigital", newName: "FunDigital");
        }
    }
}

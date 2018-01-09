namespace LabxPonto_Dao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EndEndereco_Pais : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EndEndereco", "EmpPais", c => c.String(maxLength: 100, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.EndEndereco", "EmpPais");
        }
    }
}

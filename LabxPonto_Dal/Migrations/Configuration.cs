namespace LabxPonto_Dao.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LabxPonto_Dao.Data.Context.AppDataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LabxPonto_Dao.Data.Context.AppDataContext context)
        {
        }
    }
}

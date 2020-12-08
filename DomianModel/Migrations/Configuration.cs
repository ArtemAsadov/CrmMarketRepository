namespace DomianModel.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DomianModel.Model.CrmContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;//TODO: true только на время разработки
        }

        protected override void Seed(DomianModel.Model.CrmContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}

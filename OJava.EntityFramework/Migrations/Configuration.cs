using System.Data.Entity.Migrations;

namespace OJava.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<OJava.EntityFramework.OJavaDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "OJava";
        }

        protected override void Seed(OJava.EntityFramework.OJavaDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
        }
    }
}

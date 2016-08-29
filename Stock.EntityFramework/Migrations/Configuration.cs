using System.Data.Entity.Migrations;

namespace Stock.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Stock.EntityFramework.StockDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Stock";
        }

        protected override void Seed(Stock.EntityFramework.StockDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
        }
    }
}

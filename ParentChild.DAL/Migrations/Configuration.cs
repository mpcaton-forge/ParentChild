using ParentChild.Model;

namespace ParentChild.DAL.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<ParentChild.DAL.SalesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ParentChild.DAL.SalesContext context)
        {
            context.SalesOrders.AddOrUpdate(
                so => so.CustomerName,
                new SalesOrder
                {
                    CustomerName = "Adam", PONumber = "9876", SalesOrderItems =
                    {
                        new SalesOrderItem {ProductCode = "ABC123", Quantity = 10, UnitPrice = 1.23m},
                        new SalesOrderItem {ProductCode = "XYZ987", Quantity = 7, UnitPrice = 14.75m},
                        new SalesOrderItem {ProductCode = "SAMPLE", Quantity = 3, UnitPrice = 15.00m}
                    }
                },
                new SalesOrder { CustomerName = "Michael" },
                new SalesOrder { CustomerName = "David", PONumber = "Acme 9" }
                );
        }
    }
}

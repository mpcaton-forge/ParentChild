using System.Data.Entity;
using ParentChild.Model;

namespace ParentChild.DAL
{
    public class SalesContext : DbContext
    {
        public SalesContext() : base("ParentChild")
        {
        }

        public DbSet<SalesOrder> SalesOrders { get; set; }
        public DbSet<SalesOrderItem> SalesOrderItems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new SalesOrderConfiguration());
            modelBuilder.Configurations.Add(new SalesOrderItemConfiguration());
        }
    }
}


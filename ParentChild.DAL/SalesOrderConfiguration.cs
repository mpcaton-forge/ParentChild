using System.Data.Entity.ModelConfiguration;
using ParentChild.Model;

namespace ParentChild.DAL
{
    public class SalesOrderConfiguration : EntityTypeConfiguration<SalesOrder>
    {
        public SalesOrderConfiguration()
        {
            Property(so => so.CustomerName)
                .HasMaxLength(30)
                .IsRequired();

            Property(so => so.PONumber)
                .HasMaxLength(10)
                .IsOptional();

            Ignore(so => so.ObjectState);
        }
    }
}

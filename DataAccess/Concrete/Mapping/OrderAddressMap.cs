using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.Mapping
{
    public class OrderAddressMap : IEntityTypeConfiguration<OrdersAddress>
    {
        public void Configure(EntityTypeBuilder<OrdersAddress> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.FullAddress).HasMaxLength(350);
            builder.Property(x => x.District).HasMaxLength(50);
            builder.Property(x => x.City).HasMaxLength(50);
            builder.Property(x => x.AddressType).IsRequired();
            builder.Property(x => x.OrdersId).IsRequired();

            builder.Property(x => x.CreatedBy).HasMaxLength(50);
            builder.Property(x => x.UpdateBy).HasMaxLength(50);
            builder.Property(x => x.UpdateDate).HasColumnType("datetime");
            builder.Property(x => x.CreatedDate).HasColumnType("datetime");



            builder.HasOne<Orders>(x => x.Orders).WithMany(x => x.OrdersAddress).HasForeignKey(x => x.OrdersId);

            builder.ToTable("OrdersAddress");
        }
    }
}

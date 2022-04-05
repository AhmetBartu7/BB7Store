using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.Mapping
{
    public class OrdersMap : IEntityTypeConfiguration<Orders>
    {
        public void Configure(EntityTypeBuilder<Orders> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.KDV).IsRequired();
            builder.Property(x => x.OrderStatus).IsRequired();
            builder.Property(x => x.OrderTime).HasColumnType("time");
            builder.Property(x => x.OrderType).IsRequired();
            builder.Property(x => x.TotalPrice).HasColumnType("money");
            builder.Property(x => x.DiscountPrice).HasColumnType("money");
            builder.Property(x => x.OrderDate).HasColumnType("date");
            builder.Property(x => x.CustomersId).IsRequired();
            builder.Property(x => x.CargoPrice).HasColumnType("money");
            builder.Property(x => x.CargoNumber).IsRequired();

            builder.Property(x => x.CreatedBy).HasMaxLength(50);
            builder.Property(x => x.UpdateBy).HasMaxLength(50);
            builder.Property(x => x.UpdateDate).HasColumnType("datetime");
            builder.Property(x => x.CreatedDate).HasColumnType("datetime");

            builder.HasMany<OrderDetails>(x => x.OrderDetails).WithOne(x => x.Orders).HasForeignKey(x => x.OrdersId);

            builder.HasMany<OrdersAddress>(x => x.OrdersAddress).WithOne(x => x.Orders).HasForeignKey(x => x.OrdersId);

            builder.HasOne<Customers>(x => x.Customers).WithOne(x => x.Orders).HasForeignKey<Orders>(x => x.CustomersId);

            builder.ToTable("Orders");
        }
    }
}

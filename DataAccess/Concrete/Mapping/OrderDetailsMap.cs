using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.Mapping
{
    public class OrderDetailsMap : IEntityTypeConfiguration<OrderDetails>
    {
        public void Configure(EntityTypeBuilder<OrderDetails> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.ProductsId).IsRequired();
            builder.Property(x => x.OrdersId).IsRequired();
            builder.Property(x => x.Images).HasMaxLength(50);
            builder.Property(x => x.Name).HasMaxLength(50);
            builder.Property(x => x.Piece).IsRequired();
            builder.Property(x => x.Price).HasColumnType("money");
            builder.Property(x => x.Discount).HasColumnType("money");

            builder.Property(x => x.CreatedBy).HasMaxLength(50);
            builder.Property(x => x.UpdateBy).HasMaxLength(50);
            builder.Property(x => x.UpdateDate).HasColumnType("datetime");
            builder.Property(x => x.CreatedDate).HasColumnType("datetime");



            builder.HasOne<Orders>(x => x.Orders).WithMany(x => x.OrderDetails).HasForeignKey(x => x.OrdersId);

            builder.ToTable("OrderDetails");
        }
    }
}

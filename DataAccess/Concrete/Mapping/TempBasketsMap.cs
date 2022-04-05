using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.Mapping
{
    public class TempBasketsMap : IEntityTypeConfiguration<TempBaskets>
    {
        public void Configure(EntityTypeBuilder<TempBaskets> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Images).HasMaxLength(50);
            builder.Property(x => x.Name).HasMaxLength(50);
            builder.Property(x => x.Piece).IsRequired();
            builder.Property(x => x.Price).HasColumnType("money");
            builder.Property(x => x.Discount).HasColumnType("money");
            builder.Property(x => x.ProductsId).IsRequired();
            builder.Property(x => x.CookiesId).IsRequired();

            builder.Property(x => x.CreatedBy).HasMaxLength(50);
            builder.Property(x => x.UpdateBy).HasMaxLength(50);
            builder.Property(x => x.UpdateDate).HasColumnType("datetime");
            builder.Property(x => x.CreatedDate).HasColumnType("datetime");

            builder.ToTable("TempBaskets");
        }
    }
}

using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.Mapping
{
    public class ProductsImagesMap : IEntityTypeConfiguration<ProductsImages>
    {
        public void Configure(EntityTypeBuilder<ProductsImages> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.ImagesName).HasMaxLength(25);
            builder.Property(x => x.ProductsId).IsRequired();

            builder.Property(x => x.CreatedBy).HasMaxLength(50);
            builder.Property(x => x.UpdateBy).HasMaxLength(50);
            builder.Property(x => x.UpdateDate).HasColumnType("datetime");
            builder.Property(x => x.CreatedDate).HasColumnType("datetime");

            builder.HasOne<Products>(x => x.Products).WithMany(x => x.ProductsImages).HasForeignKey(x => x.ProductsId);

            builder.ToTable("ProductsImages");
        }
    }
}

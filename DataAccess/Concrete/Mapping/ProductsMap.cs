using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.Mapping
{
    public class ProductsMap : IEntityTypeConfiguration<Products>
    {
        public void Configure(EntityTypeBuilder<Products> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Images).HasMaxLength(50);
            builder.Property(x => x.Name).HasMaxLength(50);
            builder.Property(x => x.Stock).IsRequired();
            builder.Property(x => x.Price).HasColumnType("money");
            builder.Property(x => x.Discount).HasColumnType("money");
            builder.Property(x => x.CategoriesId).IsRequired();

            builder.Property(x => x.CreatedBy).HasMaxLength(50);
            builder.Property(x => x.UpdateBy).HasMaxLength(50);
            builder.Property(x => x.UpdateDate).HasColumnType("datetime");
            builder.Property(x => x.CreatedDate).HasColumnType("datetime");

            builder.HasOne<Categories>(x => x.Categories).WithMany(x => x.Products).HasForeignKey(x => x.CategoriesId);

            builder.HasMany<ProductsImages>(x => x.ProductsImages).WithOne(x => x.Products).HasForeignKey(x => x.ProductsId);



            builder.ToTable("Products");

        }
    }
}

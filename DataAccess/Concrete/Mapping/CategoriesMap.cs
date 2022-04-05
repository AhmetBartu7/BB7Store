using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.Mapping
{
    public class CategoriesMap : IEntityTypeConfiguration<Categories>
    {
        public void Configure(EntityTypeBuilder<Categories> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.CategoryName).HasMaxLength(50).IsRequired();

            builder.Property(x => x.CreatedBy).HasMaxLength(50);
            builder.Property(x => x.UpdateBy).HasMaxLength(50);
            builder.Property(x => x.UpdateDate).HasColumnType("datetime");
            builder.Property(x => x.CreatedDate).HasColumnType("datetime");


            builder.HasMany<Products>(x => x.Products).WithOne(x => x.Categories).HasForeignKey(x => x.CategoriesId);

            builder.ToTable("Categories");
        }
    }
}

using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.Mapping
{
    public class CustomersMap : IEntityTypeConfiguration<Customers>
    {
        public void Configure(EntityTypeBuilder<Customers> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.NameSurName).HasMaxLength(50);
            builder.Property(x => x.Password).HasMaxLength(25);
            builder.Property(x => x.Phone).HasMaxLength(15);
            builder.Property(x => x.Role).HasMaxLength(10);
            builder.Property(x => x.FullAddress).HasMaxLength(350);
            builder.Property(x => x.Email).HasMaxLength(50);
            builder.Property(x => x.Disctrict).HasMaxLength(50);
            builder.Property(x => x.City).HasMaxLength(50);

            builder.Property(x => x.CreatedBy).HasMaxLength(50);
            builder.Property(x => x.UpdateBy).HasMaxLength(50);
            builder.Property(x => x.UpdateDate).HasColumnType("datetime");
            builder.Property(x => x.CreatedDate).HasColumnType("datetime");



            builder.ToTable("Customers");
        }
    }
}

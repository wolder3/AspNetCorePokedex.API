using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AspNetCorePokedex.Domain.Entities;

namespace AspNetCorePokedex.Infrastructure.Data.Configurations
{
    public class TypeConfiguration : IEntityTypeConfiguration<Type>
    {
        public void Configure(EntityTypeBuilder<Type> builder)
        {
             builder.ToTable("type");

             builder.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

             builder.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("name");
        }
    }
}

using AspNetCorePokedex.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
 
namespace AspNetCorePokedex.Infrastructure.Data.Configurations
{
    public class MoveConfiguration : IEntityTypeConfiguration<Move>
    {
        public void Configure(EntityTypeBuilder<Move> builder)
        {
            builder.ToTable("move");

            builder.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");

            builder.Property(e => e.Accuracy).HasColumnName("accuracy");

            builder.Property(e => e.Category)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("category");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("name");

            builder.Property(e => e.Power)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("power");

            builder.Property(e => e.Pp)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("pp");

            builder.Property(e => e.TypeId).HasColumnName("type_id");

            builder.HasOne(d => d.Type)
                .WithMany(p => p.Moves)
                .HasForeignKey(d => d.TypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_move_type");
        }
    }
}

using AspNetCorePokedex.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
 
namespace AspNetCorePokedex.Infrastructure.Data.Configurations
{
    public class BaseConfiguration : IEntityTypeConfiguration<Base>
    {
        public void Configure(EntityTypeBuilder<Base> builder)
        {
            builder.ToTable("base");

            builder.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");

            builder.Property(e => e.Attack).HasColumnName("attack");

            builder.Property(e => e.Defense).HasColumnName("defense");

            builder.Property(e => e.Hp).HasColumnName("hp");

            builder.Property(e => e.PokemonId).HasColumnName("pokemon_id");

            builder.Property(e => e.SpAttack).HasColumnName("sp_attack");

            builder.Property(e => e.SpDefense).HasColumnName("sp_defense");

            builder.Property(e => e.Speed).HasColumnName("speed");

            builder.HasOne(d => d.Pokemon)
                .WithMany(p => p.Bases)
                .HasForeignKey(d => d.PokemonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_base_pokemon");
        }
    }
}

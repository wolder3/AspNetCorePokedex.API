using AspNetCorePokedex.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCorePokedex.Infrastructure.Data.Configurations
{
    public class PokemonTypeConfiguration : IEntityTypeConfiguration<PokemonType>
    {
        public void Configure(EntityTypeBuilder<PokemonType> builder)
        {
            builder.HasKey(e => new { e.PokemonId, e.TypeId })
                   .HasName("pk_pokemon_type");

            builder.ToTable("pokemon_type");

            builder.Property(e => e.PokemonId).HasColumnName("pokemon_id");

            builder.Property(e => e.TypeId).HasColumnName("type_id");

            builder.HasOne(d => d.Pokemon)
                .WithMany(p => p.PokemonTypes)
                .HasForeignKey(d => d.PokemonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_pokemon_type_pokemon");

            builder.HasOne(d => d.Type)
                .WithMany(p => p.PokemonTypes)
                .HasForeignKey(d => d.TypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_pokemon_type_type");
        }
    }
}

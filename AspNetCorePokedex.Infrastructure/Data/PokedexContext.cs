using AspNetCorePokedex.Domain.Entities;
using AspNetCorePokedex.Infrastructure.Data.Configurations;
using Microsoft.EntityFrameworkCore;

namespace AspNetCorePokedex.Infrastructure.Data
{
    public partial class PokedexContext : DbContext
    {
        public PokedexContext()
        {
        }

        public PokedexContext(DbContextOptions<PokedexContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Base> Bases { get; set; }
        public virtual DbSet<Move> Moves { get; set; }
        public virtual DbSet<Pokemon> Pokemons { get; set; }
        public virtual DbSet<PokemonType> PokemonTypes { get; set; }
        public virtual DbSet<Type> Types { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.ApplyConfiguration(new BaseConfiguration());
            modelBuilder.ApplyConfiguration(new MoveConfiguration());
            modelBuilder.ApplyConfiguration(new PokemonConfiguration());
            modelBuilder.ApplyConfiguration(new PokemonTypeConfiguration());
            modelBuilder.ApplyConfiguration(new TypeConfiguration());

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

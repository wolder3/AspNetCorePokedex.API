using System.Collections.Generic;

namespace AspNetCorePokedex.Domain.Entities
{
    public partial class Type
    {
        public Type()
        {
            Moves = new HashSet<Move>();
            PokemonTypes = new HashSet<PokemonType>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Move> Moves { get; set; }
        public virtual ICollection<PokemonType> PokemonTypes { get; set; }
    }
}

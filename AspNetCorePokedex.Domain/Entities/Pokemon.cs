using System.Collections.Generic;

namespace AspNetCorePokedex.Domain.Entities
{
    public partial class Pokemon
    {
        public Pokemon()
        {
            Bases = new Base();
            PokemonTypes = new HashSet<PokemonType>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual Base Bases { get; set; }
        public virtual ICollection<PokemonType> PokemonTypes { get; set; }
    }
}

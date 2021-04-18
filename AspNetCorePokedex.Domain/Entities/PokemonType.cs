using System;
 
namespace AspNetCorePokedex.Domain.Entities
{
    public partial class PokemonType
    {
        public int PokemonId { get; set; }
        public int TypeId { get; set; }

        public virtual Pokemon Pokemon { get; set; }
        public virtual Type Type { get; set; }
    }
}

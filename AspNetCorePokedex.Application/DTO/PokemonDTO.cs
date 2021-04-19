using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCorePokedex.Application.DTO
{
    public class PokemonDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual BaseDTO Bases { get; set; }
        
    }
}

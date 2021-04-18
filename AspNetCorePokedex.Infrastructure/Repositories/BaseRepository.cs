using AspNetCorePokedex.Application.Interfaces.Repositories;
using AspNetCorePokedex.Domain.Entities;
using AspNetCorePokedex.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCorePokedex.Infrastructure.Repositories
{
    public class BaseRepository : IBaseRepository
    {
        private readonly PokedexContext _context;
        public BaseRepository(PokedexContext context)
        {
            _context = context;
        }

        public async Task<Base> GetByIdPokemonAsync(int pokemonId)
        {
            return await _context.Bases.FirstAsync(x => x.PokemonId == pokemonId);
        }
    }
}

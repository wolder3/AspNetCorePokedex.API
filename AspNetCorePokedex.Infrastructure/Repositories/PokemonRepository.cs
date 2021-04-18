using AspNetCorePokedex.Application.Interfaces.Repositories;
using AspNetCorePokedex.Domain.Entities;
using AspNetCorePokedex.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace AspNetCorePokedex.Infrastructure.Repositories
{
    public class PokemonRepository : IPokemonRepository
    {
        private readonly PokedexContext _context;
        public PokemonRepository(PokedexContext context)
        {
            _context = context;
        }
        public async Task<Pokemon> GetByIdAsync(int pokemonId)
        {
            return await _context.Pokemons.FirstOrDefaultAsync(x => x.Id == pokemonId);
        }

        public async Task<List<Pokemon>> GetListAsync()
        {
            return await _context.Pokemons.ToListAsync();
        }

        public async Task<List<Pokemon>> GetListByNameAsync(string pokemonName)
        {
            return await _context.Pokemons.Where(x => x.Name.ToUpper().Contains(pokemonName.ToUpper())).ToListAsync();
        }
    }
}

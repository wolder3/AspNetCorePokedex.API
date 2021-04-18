using AspNetCorePokedex.Application.Interfaces.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetCorePokedex.Domain.Entities;
using AspNetCorePokedex.Infrastructure.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace AspNetCorePokedex.Infrastructure.Repositories
{
    public class TypeRepository : ITypeRepository
    {
        private readonly PokedexContext _context;

        public TypeRepository(PokedexContext context)
        {
            _context = context;
        }

        public async Task<List<Type>> GetListByIdPokemonAsync(int pokemonId)
        {
           return await _context.Types.Where(x => x.PokemonTypes.Any(p => p.PokemonId == pokemonId)).AsNoTracking().ToListAsync();
             
        }
    }
}

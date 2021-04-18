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
    public class MoveRepository : IMoveRepository
    {
        private readonly PokedexContext _context;
        public MoveRepository(PokedexContext context)
        {
            _context = context;
        }

        public async Task<List<Move>> GetMoveByIdAsync(int pokemonId)
        {
            List<Move> ListMove = new List<Move>();

            var ListType = await _context.Types.Where(x => x.PokemonTypes.Any(p => p.PokemonId == pokemonId)).ToListAsync();

            foreach (var type in ListType)
            {
                ListMove.AddRange(_context.Moves.Where(x => x.TypeId == type.Id).AsNoTracking().ToList());
            }

            return ListMove;
        }
    }
}

using AspNetCorePokedex.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AspNetCorePokedex.Application.Interfaces.Repositories
{
    public interface IMoveRepository
    {
        Task<List<Move>> GetMoveByIdAsync(int pokemonId);
    }
}

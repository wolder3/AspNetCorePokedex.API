using AspNetCorePokedex.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AspNetCorePokedex.Application.Interfaces.Repositories
{
    public interface IPokemonRepository
    {
        Task<List<Pokemon>> GetListAsync();
        Task<Pokemon> GetByIdAsync(int pokemonId);
        Task<List<Pokemon>> GetListByNameAsync(string pokemonName);
    }
}

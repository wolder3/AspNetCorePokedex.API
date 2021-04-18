using AspNetCorePokedex.Domain.Entities;
using System.Threading.Tasks;

namespace AspNetCorePokedex.Application.Interfaces.Repositories
{
    public interface IBaseRepository
    {
        Task<Base> GetByIdPokemonAsync(int pokemonId);
    }
}

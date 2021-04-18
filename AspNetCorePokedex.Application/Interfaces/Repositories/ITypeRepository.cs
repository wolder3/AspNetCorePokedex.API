
using AspNetCorePokedex.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AspNetCorePokedex.Application.Interfaces.Repositories
{
    public interface ITypeRepository
    {
        Task<List<Type>> GetListByIdPokemonAsync(int pokemonId);
    }
}

using AspNetCorePokedex.Application.Interfaces.Repositories;
using AspNetCorePokedex.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace AspNetCorePokedex.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            #region Repositories

            services.AddTransient<IBaseRepository, BaseRepository>();
            services.AddTransient<IMoveRepository, MoveRepository>();
            services.AddTransient<IPokemonRepository, PokemonRepository>();
            services.AddTransient<ITypeRepository, TypeRepository>();

            #endregion Repositories
        }
    }
}

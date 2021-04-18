using AspNetCorePokedex.Application.Interfaces.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCorePokedex.Api.Controllers
{
    public class PokemonController : BaseApiController<PokemonController>
    {
        private readonly IPokemonRepository _pokemonRepository;

        public PokemonController(IPokemonRepository pokemonRepository)
        {
            _pokemonRepository = pokemonRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var Pokemons = await _pokemonRepository.GetListAsync();
            return Ok(Pokemons);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _pokemonRepository.GetByIdAsync(id));
        }

        [HttpGet("GetByName/{name}")]
        public async Task<IActionResult> GetByName(string name)
        {
            return Ok(await _pokemonRepository.GetListByNameAsync(name));
        }
    }
}

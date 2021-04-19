using AspNetCorePokedex.Application.DTO;
using AspNetCorePokedex.Application.Interfaces.Repositories;
using AspNetCorePokedex.Domain.Entities;
using AutoMapper;
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
        private readonly IMapper _mapper;

        public PokemonController(IPokemonRepository pokemonRepository, IMapper mapper)
        {
            _pokemonRepository = pokemonRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            List<Pokemon> Pokemons = await _pokemonRepository.GetListAsync();
            var ListPokemonDTO = _mapper.Map<List<PokemonDTO>>(Pokemons);
            return Ok(ListPokemonDTO);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var pokemon = await _pokemonRepository.GetByIdAsync(id);
            var pokemonDTO =  _mapper.Map<PokemonDTO>(pokemon);
            return Ok(pokemonDTO);
        }

        [HttpGet("GetByName/{name}")]
        public async Task<IActionResult> GetByName(string name)
        {
            List<Pokemon> Pokemons = await _pokemonRepository.GetListByNameAsync(name);
            var ListPokemonDTO = _mapper.Map<List<PokemonDTO>>(Pokemons);
            return Ok(ListPokemonDTO);
        }
    }
}

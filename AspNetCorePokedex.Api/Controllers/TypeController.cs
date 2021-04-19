using AspNetCorePokedex.Application.DTO;
using AspNetCorePokedex.Application.Interfaces.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCorePokedex.Api.Controllers
{
    public class TypeController : BaseApiController<TypeController>
    {
        private readonly ITypeRepository _typeRepository;
        private readonly IMapper _mapper;
        public TypeController(ITypeRepository typeRepository, IMapper mapper)
        {
            _typeRepository = typeRepository;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAll(int id)
        {
            var Types = await _typeRepository.GetListByIdPokemonAsync(id);
            var TypesDTO = _mapper.Map<List<TypeDTO>>(Types);
            return Ok(TypesDTO);
        }
    }
}

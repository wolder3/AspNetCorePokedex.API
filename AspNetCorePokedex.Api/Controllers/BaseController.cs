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
    public class BaseController : BaseApiController<BaseController>
    {
        private readonly IBaseRepository _baseRepository;
        private readonly IMapper _mapper;
        public BaseController(IBaseRepository baseRepository, IMapper mapper)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var Bases = await _baseRepository.GetByIdPokemonAsync(id);
            var BasesDTO = _mapper.Map<List<TypeDTO>>(Bases);
            return Ok(BasesDTO);
        }
    }
}

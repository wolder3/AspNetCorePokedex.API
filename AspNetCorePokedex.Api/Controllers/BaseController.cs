using AspNetCorePokedex.Application.Interfaces.Repositories;
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
        public BaseController(IBaseRepository baseRepository)
        {
            _baseRepository = baseRepository;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var Types = await _baseRepository.GetByIdPokemonAsync(id);
            return Ok(Types);
        }
    }
}

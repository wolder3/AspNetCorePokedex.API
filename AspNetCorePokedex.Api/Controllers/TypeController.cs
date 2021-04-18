using AspNetCorePokedex.Application.Interfaces.Repositories;
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
        public TypeController(ITypeRepository typeRepository)
        {
            _typeRepository = typeRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(int id)
        {
            var Types = await _typeRepository.GetListByIdPokemonAsync(id);
            return Ok(Types);
        }
    }
}

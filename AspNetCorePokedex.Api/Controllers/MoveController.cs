using AspNetCorePokedex.Application.DTO;
using AspNetCorePokedex.Application.Interfaces.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AspNetCorePokedex.Api.Controllers
{
    public class MoveController : BaseApiController<MoveController>
    {
        private readonly IMoveRepository _moveRepository;
        private readonly IMapper _mapper;
        public MoveController(IMoveRepository moveRepository, IMapper mapper)
        {
            _moveRepository = moveRepository;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAll(int id)
        {
            var Moves = await _moveRepository.GetMoveByIdAsync(id);
            var MovesDTO = _mapper.Map<List<MoveDTO>>(Moves);
            return Ok(MovesDTO);
        }

    }
}

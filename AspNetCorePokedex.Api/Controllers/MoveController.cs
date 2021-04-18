using AspNetCorePokedex.Application.Interfaces.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AspNetCorePokedex.Api.Controllers
{
    public class MoveController : BaseApiController<MoveController>
    {
        private readonly IMoveRepository _moveRepository;
        public MoveController(IMoveRepository moveRepository)
        {
            _moveRepository = moveRepository;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAll(int id)
        {
            var Moves = await _moveRepository.GetMoveByIdAsync(id);
            return Ok(Moves);
        }

    }
}

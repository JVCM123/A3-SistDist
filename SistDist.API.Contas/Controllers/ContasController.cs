using Microsoft.AspNetCore.Mvc;
using SistDist.Domain.Interfaces;
using SistDist.Domain.Models;

namespace SistDist.API.Contas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContasController : ControllerBase
    {
        private readonly IContaRepository _contaRepository;

        public ContasController(IContaRepository contaRepository)
        {
            _contaRepository = contaRepository;
        }

        [HttpGet("GetContas")]
        public async Task<IEnumerable<Conta>> Get()
        {
            return await _contaRepository.Get();
        }
    }
}

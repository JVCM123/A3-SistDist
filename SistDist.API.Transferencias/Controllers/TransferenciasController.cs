using Microsoft.AspNetCore.Mvc;
using SistDist.Domain.Interfaces;
using SistDist.Domain.Models;

namespace SistDist.API.Transferencias.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransferenciasController : ControllerBase
    {
        private readonly ITransferenciasRepository _transferenciasRepository;

        public TransferenciasController(ITransferenciasRepository transferenciasRepository)
        {
            _transferenciasRepository = transferenciasRepository;
        }

        [HttpGet("GetTransferencias")]
        public async Task<IEnumerable<Transferencia>> Get()
        {
            return await _transferenciasRepository.Get();
        }
    }
}

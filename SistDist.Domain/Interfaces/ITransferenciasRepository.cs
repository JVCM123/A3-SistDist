using SistDist.Domain.Models;

namespace SistDist.Domain.Interfaces
{
    public interface ITransferenciasRepository
    {
        Task<IEnumerable<Transferencia>> Get();
    }
}

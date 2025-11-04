using SistDist.Domain.Models;

namespace SistDist.Domain.Interfaces
{
    public interface ITransferenciasRepository
    {
        Task<IEnumerable<Transferencia>> Get();
        Task<IEnumerable<Transferencia>> GetByDestinatario(Guid contaDestinatarioId);
        Task<IEnumerable<Transferencia>> GetByRemetente(Guid contaRemetenteId);
    }
}

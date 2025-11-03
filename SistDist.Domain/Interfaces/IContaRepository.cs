using SistDist.Domain.Models;

namespace SistDist.Domain.Interfaces
{
    public interface IContaRepository
    {
        Task<IEnumerable<Conta>> GetContas();
    }
}

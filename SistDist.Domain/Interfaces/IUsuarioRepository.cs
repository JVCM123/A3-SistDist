using SistDist.Domain.Models;

namespace SistDist.Domain.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<IEnumerable<Usuario>> Get();
        public Task<Usuario> GetById(Guid id);
    }
}

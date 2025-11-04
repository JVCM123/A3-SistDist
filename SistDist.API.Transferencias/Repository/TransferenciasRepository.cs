using SistDist.Domain.Interfaces;
using SistDist.Domain.Models;
using System.Text.Json;

namespace SistDist.API.Transferencias.Repository
{
    public class TransferenciasRepository : ITransferenciasRepository
    {
        private readonly string _path = Path.Combine(Environment.CurrentDirectory, "DataMock.json");

        public Task<IEnumerable<Transferencia>> Get()
        {
            var jsonData = File.ReadAllText(_path);
            var transferencias = JsonSerializer.Deserialize<IEnumerable<Transferencia>>(jsonData);

            return Task.FromResult(transferencias);
        }

        public async Task<IEnumerable<Transferencia>> GetByDestinatario(Guid contaDestinatarioId)
        {
            var jsonData = File.ReadAllText(_path);
            var transferencias = JsonSerializer.Deserialize<IEnumerable<Transferencia>>(jsonData);

            return transferencias.Where(t => t.DestinatarioId == contaDestinatarioId);
        }

        public async Task<IEnumerable<Transferencia>> GetByRemetente(Guid contaRemetenteId)
        {
            var jsonData = File.ReadAllText(_path);
            var transferencias = JsonSerializer.Deserialize<IEnumerable<Transferencia>>(jsonData);

            return transferencias.Where(t => t.RemetenteId == contaRemetenteId);
        }
    }
}

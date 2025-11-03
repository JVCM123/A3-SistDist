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
            var contas = JsonSerializer.Deserialize<IEnumerable<Transferencia>>(jsonData);

            return Task.FromResult(contas);
        }
    }
}

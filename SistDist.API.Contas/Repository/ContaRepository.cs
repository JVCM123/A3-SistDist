using SistDist.Domain.Interfaces;
using SistDist.Domain.Models;
using System.Text.Json;

namespace SistDist.API.Contas.Repository
{
    public class ContaRepository : IContaRepository
    {
        private readonly string _path = Path.Combine(Environment.CurrentDirectory, "DataMock.json");

        public Task<IEnumerable<Conta>> GetContas()
        {
            var jsonData = File.ReadAllText(_path);
            var contas = JsonSerializer.Deserialize<IEnumerable<Conta>>(jsonData);

            return Task.FromResult(contas);
        }
    }
}

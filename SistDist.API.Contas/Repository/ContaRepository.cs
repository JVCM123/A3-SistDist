using SistDist.Domain.Interfaces;
using SistDist.Domain.Models;
using System.Text.Json;

namespace SistDist.API.Contas.Repository
{
    public class ContaRepository : IContaRepository
    {
        private readonly string _path = Path.Combine(Environment.CurrentDirectory, "DataMock.json");

        public Task<IEnumerable<Conta>> Get()
        {
            var jsonData = File.ReadAllText(_path);
            var contas = JsonSerializer.Deserialize<IEnumerable<Conta>>(jsonData);

            return Task.FromResult(contas);
        }

        public async Task<Conta> GetById(Guid id)
        {
            var jsonData = File.ReadAllText(_path);
            var contas = JsonSerializer.Deserialize<IEnumerable<Conta>>(jsonData);

            var conta = contas.FirstOrDefault(c => c.Id == id);

            return conta ?? new();
        }
    }
}

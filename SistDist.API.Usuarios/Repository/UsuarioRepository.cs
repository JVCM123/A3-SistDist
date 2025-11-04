using SistDist.Domain.Interfaces;
using SistDist.Domain.Models;
using System.Text.Json;

namespace SistDist.API.Usuarios.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly string _path = Path.Combine(Environment.CurrentDirectory, "DataMock.json");

        public Task<IEnumerable<Usuario>> Get()
        {
            var jsonData = File.ReadAllText(_path);
            var usuarios = JsonSerializer.Deserialize<IEnumerable<Usuario>>(jsonData);

            return Task.FromResult(usuarios);
        }

        public async Task<Usuario> GetById(Guid id)
        {
            var jsonData = File.ReadAllText(_path);
            var usuarios = JsonSerializer.Deserialize<IEnumerable<Usuario>>(jsonData);

            var usuario = usuarios.FirstOrDefault(c => c.Id == id);

            return usuario ?? new();
        }
    }
}

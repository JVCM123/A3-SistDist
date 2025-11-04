using Microsoft.AspNetCore.Mvc;
using SistDist.Domain.Interfaces;
using SistDist.Domain.Models;

namespace SistDist.API.Usuarios.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuariosController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [HttpGet("GetUsuarios")]
        public async Task<IEnumerable<Usuario>> Get()
        {
            return await _usuarioRepository.Get();
        }
    }
}

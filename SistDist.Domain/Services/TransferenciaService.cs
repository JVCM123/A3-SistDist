using SistDist.Domain.Interfaces;
using SistDist.Domain.Models;

namespace SistDist.Domain.Services
{
    public class TransferenciaService
    {
        private readonly IContaRepository _contaRepository;
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly ITransferenciasRepository _transferenciasRepository;

        public TransferenciaService(IContaRepository contaRepository, IUsuarioRepository usuarioRepository, ITransferenciasRepository transferenciasRepository)
        {
            _contaRepository = contaRepository;
            _usuarioRepository = usuarioRepository;
            _transferenciasRepository = transferenciasRepository;
        }

        public async Task RealizarTransferencia(Transferencia pix)
        {
            decimal indiceFraude = 0;

            var contaDestinataria = await _contaRepository.GetById(pix.DestinatarioId);
            var destinatario = await _usuarioRepository.GetById(contaDestinataria.UsuarioId);

            var contaRemetente = await _contaRepository.GetById(pix.RemetenteId);
            var remetente = await _usuarioRepository.GetById(contaRemetente.UsuarioId);
            var transferenciasRemetente = await _transferenciasRepository.GetByRemetente(contaRemetente.Id);

            /// Validar média de transferências do remetente, se for maior, aumentar o índice de fraude
            /// Criar tabela de possiveis fraudes, armazenando id da transferencia e o indice de fraude
        }
    }
}

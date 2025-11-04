namespace SistDist.Domain.Models
{
    public class Conta
    {
        public Guid Id { get; set; }
        public decimal Saldo { get; set; }
        public decimal Limite { get; set; }
        public bool Ativa { get; set; }
        public string ChavePix { get; set; }
        public Guid UsuarioId { get; set; }
    }
}

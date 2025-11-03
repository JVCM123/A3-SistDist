namespace SistDist.Domain.Models
{
    public class Transferencia
    {
        public Guid Id { get; set; }
        public decimal Valor { get; set; }
        public Guid DestinatarioId { get; set; }
        public Guid RemetenteId { get; set; }
        public DateTime Data { get; set; }
    }
}

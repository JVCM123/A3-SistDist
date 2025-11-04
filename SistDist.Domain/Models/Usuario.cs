namespace SistDist.Domain.Models
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public DateTime DtNascimento { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Tipo { get; set; }
        public string Documento { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace SistemaLocacao.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public bool Alugando { get; set; }
    }
}

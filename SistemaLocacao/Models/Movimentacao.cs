using System.ComponentModel.DataAnnotations;

namespace SistemaLocacao.Models
{
    public class Movimentacao
    {
        public int MovimentacaoId { get; set; }
        public int ClienteId { get; set; }
        public Cliente? Cliente { get; set; }
        public int FilmeId { get; set; }
        public Filme? Filme { get; set; }
        [Display(Name = "Data de Locação")]
        public DateOnly Datalocacao { get; set; }
        [Display(Name = "Data de Devolução")]
        public DateOnly Datadevolucao { get; set; }


    }
}

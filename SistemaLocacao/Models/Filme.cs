using System.ComponentModel.DataAnnotations;

namespace SistemaLocacao.Models
{
    public class Filme
    {
        public int FilmeId { get; set; }
        [Display(Name = "Título")]
        public string Titulo { get; set; }
        [Display(Name = "Gênero")]
        public string Genero { get; set; }
        [Display(Name = "Ano de Lançamento")]
        public int AnoLancamento { get; set; }
        public string Diretor { get; set; }
        [Display(Name = "Preço")]
        public decimal Preco { get; set; }
        [Display(Name = "Estúdio")]
        public string Estudio { get; set; }
        public string Distribuidora { get; set; }
        [Display(Name = "Disponível")]
        public bool Disponivel { get; set; } = true;

        public int? ClienteId { get; set; }
        public Cliente? Cliente { get; set; }
    }
}

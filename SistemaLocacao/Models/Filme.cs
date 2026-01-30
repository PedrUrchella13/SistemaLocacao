namespace SistemaLocacao.Models
{
    public class Filme
    {
        public int FilmeId { get; set; }
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public int AnoLancamento { get; set; }
        public string Diretor { get; set; }
        public decimal Preco { get; set; }
        public string Estudio { get; set; }
        public string Distribuidora { get; set; }
        public bool Disponivel { get; set; }

        public int ClienteId { get; set; }
        public Cliente? Cliente { get; set; }
    }
}

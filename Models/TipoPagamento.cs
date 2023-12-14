namespace ryanAps.Models
{
    public class TipoPagamento
    {
        public int Id { get; set; }
        public string? NomeDoCobrado { get; set; }
        public string? InformacoesAdcionais { get; set; }
        public virtual ICollection<NotaDeVenda>? NotasDeVenda { get; set; }
    }
}

namespace ryanAps.Models
{
    public class PagamentoComCheque : TipoPagamento
    {
        public string? NumeroDoCheque { get; set; }
        public int? Banco { get; set; }
    }
}
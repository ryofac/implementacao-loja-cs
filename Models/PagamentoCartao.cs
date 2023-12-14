namespace ryanAps.Models
{
    public class PagamentoCartao : TipoPagamento
    {
        public string? NumeroDoCartao { get; set; }
        public string? Bandeira { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;

namespace ryanAps.Models
{
    public class PagamentoCartao : TipoPagamento
    {
        [Key]
        public string? NumeroDoCartao { get; set; }
        public string? Bandeira { get; set; }
    }
}
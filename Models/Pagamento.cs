namespace ryanAps.Models
{
    public class Pagamento {
        public int Id { get; set; }
        public DateTime DataLimite { get; set; }
        public double Valor { get; set; }
        public bool Pago { get; set; }
        public int NotaDeVendaId { get; set; }
        public virtual NotaDeVenda? NotaDeVenda { get; set; }
    }
}
namespace ryanAps.Models
{
    public class NotaDeVenda {
        public int Id { get; set; }
        public bool Tipo { get; set; }
        public DateTime? Data { get; set; }

        public int ItemId { get; set; }
        public virtual Item? Item { get; set; }

        public int ClienteId { get; set; }
        public virtual Cliente? Cliente { get; set; }

        public int VendedorId { get; set; }
        public virtual Vendedor? Vendedor { get; set; }

        public int? TransportadoraId { get; set; }
        public virtual Transportadora? Transportadora { get; set; }

        public int TipoPagamentoId { get; set; }
        public virtual TipoPagamento? TipoPagamento { get; set; }
        public virtual ICollection<Pagamento>? Pagamentos { get; set; }

    }
}
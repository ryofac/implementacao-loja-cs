namespace ryanAps.Models
{
    public class NotaDeVenda{
        public int Id { get; set; }
        public bool Tipo { get; set; }
        public DateTime? Data { get; set; }
        public virtual ICollection<Item>? Itens { get; set; }

        public int ClienteId { get; set; }
        public virtual Cliente? Cliente { get; set; }

        public int VendedorId { get; set; }
        public virtual Vendedor? Vendedor { get; set; }

        public int? TransportadoraId { get; set; }
        public virtual Transportadora? Transportadora { get; set; }



    }
}
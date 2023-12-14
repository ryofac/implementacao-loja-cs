namespace ryanAps.Models{
    public class Produto{
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public decimal Preco { get; set; }
        public int MarcaId { get; set; }
        public virtual Marca? Marca { get; set; }
    }
}
using System.Collections;

namespace ryanAps.Models
{
    public class Item
    {
        public int Id { get; set; }
        public double Preco { get; set; }
        public int Percentual {get; set;}
        public int Quantidade { get; set; }
        public virtual ICollection<Produto>? Produtos { get; set; }
        public virtual ICollection<NotaDeVenda>? NotasDeVenda { get; set; }
    }
}
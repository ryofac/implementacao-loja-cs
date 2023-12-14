using Microsoft.EntityFrameworkCore;
using ryanAps.Models;
namespace ryanAps.Models {
   
    public class MyDbContext : DbContext {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { 
            
        }
        public DbSet<ryanAps.Models.Cliente> Cliente { get; set; }
        public DbSet<ryanAps.Models.Item> Item { get; set; }
        public DbSet<ryanAps.Models.Marca> Marca { get; set; }
        public DbSet<ryanAps.Models.NotaDeVenda> NotaDeVenda { get; set; }
        public DbSet<ryanAps.Models.Pagamento> Pagamento { get; set; }
        public DbSet<ryanAps.Models.Produto> Produto { get; set; }
        public DbSet<ryanAps.Models.TipoPagamento> TipoPagamento { get; set; }
        public DbSet<ryanAps.Models.Transportadora> Transportadora { get; set; }
        public DbSet<ryanAps.Models.Vendedor> Vendedor { get; set; }
        public DbSet<ryanAps.Models.PagamentoCartao> PagamentoCartao { get; set; }
        public DbSet<ryanAps.Models.PagamentoComCheque> PagamentoComCheque { get; set; }

    }
}
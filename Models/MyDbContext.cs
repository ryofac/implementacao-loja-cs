using Microsoft.EntityFrameworkCore;
namespace ryanAps.Models {
   
    public class MyDbContext : DbContext {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { 
            
        }
        
        
    }
}
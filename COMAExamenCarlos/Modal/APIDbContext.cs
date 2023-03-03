using Microsoft.EntityFrameworkCore;

namespace COMAExamenCarlos.Modal
{
    public class APIDbContext:DbContext
    {
        public APIDbContext(DbContextOptions option) : base(option) 
        {
                    
        }

        public DbSet<clientes> Clientes { get; set; }

        public DbSet<facturas> Facturas { get; set; }

    }
}

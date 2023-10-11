using Microsoft.EntityFrameworkCore;

namespace mf_dev_backend_2023.Models
{
    public class AppDbContext : DbContext //Essa classe tem a função de configurar o Entity Framework e manipulação de dados
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Veiculo> Veiculos { get; set; }
    }
}

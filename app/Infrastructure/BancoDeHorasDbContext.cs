using app.Models;
using Microsoft.EntityFrameworkCore;

namespace app.Infrastructure
{
    public class BancoDeHorasDbContext(DbContextOptions options) : DbContext(options)
    {

        public DbSet<Funcionarios> Funcionarios { get; set; }
        public DbSet<RegistrosDeHoras> RegistrosDeHoras { get; set; }
        public DbSet<Atividades> Atividades { get; set; }

    }
}
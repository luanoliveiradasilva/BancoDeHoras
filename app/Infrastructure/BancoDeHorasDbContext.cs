using app.Models;
using Microsoft.EntityFrameworkCore;

namespace app.Infrastructure
{
    public class BancoDeHorasDbContext(DbContextOptions options) : DbContext(options)
    {

        public DbSet<Funcionarios> Filmes { get; set; }
        public DbSet<RegistrosDeHoras> Diretores { get; set; }
        public DbSet<Atividades> Generos { get; set; }

    }
}
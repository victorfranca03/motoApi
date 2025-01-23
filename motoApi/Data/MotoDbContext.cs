using Microsoft.EntityFrameworkCore;
using motoApi.Models;


namespace motoApi.Data
{
    public class MotoDbContext : DbContext
    {
        public MotoDbContext(DbContextOptions<MotoDbContext> options) : base(options) { }

        public DbSet<Moto> motos { get; set; }// Representa a tabela de motos no Banco

    }
}

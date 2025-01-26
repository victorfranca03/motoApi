using Microsoft.EntityFrameworkCore;
using motoApi.Models;

namespace motoApi.Context
{
    public class MotoContext : DbContext
    {
        public MotoContext(DbContextOptions <MotoContext>  options) : base(options){ }

        public DbSet<Moto.Models.Moto> Motos { get; set; }
    }
}

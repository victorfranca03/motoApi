using Microsoft.EntityFrameworkCore;
using motoApi.Models;

namespace motoApi.Context
{
    public class MotoContext : DbContext
    {
        public MotoContext(DbContextOptions <MotoContext>  options) : base(options){ }

        public DbSet<motoApi.Models.Moto> Motos { get; set; }
    }
}

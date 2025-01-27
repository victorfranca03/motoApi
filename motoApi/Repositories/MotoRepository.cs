using motoApi.Context;
using motoApi.Models;
using Microsoft.EntityFrameworkCore;

namespace motoApi.Repositories
{
    public class MotoRepository
    {
        private readonly MotoContext _context;

        public MotoRepository(MotoContext context)
        {
            _context = context;
        }

        public async Task<List<Moto>> GetAll()
        {
            return await _context.Motos.ToListAsync();
        }

        public async Task AddMoto(Moto moto)
        {
            await _context.Motos.AddAsync(moto);
            await _context.SaveChangesAsync();
        }
    }
}

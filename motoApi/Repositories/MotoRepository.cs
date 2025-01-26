using motoApi.Context;
namespace motoApi.Repositories
{
    public class MotoRepository
    {
        private readonly MotoRepository _context;

        public MotoRepository(MotoContext context)
        {
            _context = context;
        }
    }
}

using motoApi.Models;
using motoApi.Repositories;

namespace motoApi.Services
{
    public class MotoService
    {
        public class MotoServices
        {
            private readonly MotoRepository _motoRepository;

            public MotoServices(MotoRepository motoRepository)
            {

                _motoRepository = motoRepository;
            }

            public List<Moto> GetAll()
            {
                return _motoRepository.GetAll().Result;
            }

            public async Task CreateAsync(Moto moto)
            {
                if (moto == null)
                    throw new ArgumentNullException(nameof(moto));
                await _motoRepository.AddMoto(moto);
            }
        }
    }
}

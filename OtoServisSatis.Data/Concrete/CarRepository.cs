using Microsoft.EntityFrameworkCore;
using OtoServisSatis.Data.Abstract;
using OtoServisSatis.Entities;

namespace OtoServisSatis.Data.Concrete
{
    public class CarRepository : Repository<Arac>, ICarRepository
    {
        public CarRepository(DatabaseContext context) : base(context)
        {
        }

        public async Task<Arac> GetCustomCar(int id)
        {
            return await _dbSet.AsNoTracking().Include(x => x.Marka).FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<IEnumerable<Arac>> GetCustomCarList()
        {
           return await _dbSet.AsNoTracking().Include(x=>x.Marka).ToListAsync();
        }
    }
}

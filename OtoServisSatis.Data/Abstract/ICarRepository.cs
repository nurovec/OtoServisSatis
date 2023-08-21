using OtoServisSatis.Entities;

namespace OtoServisSatis.Data.Abstract
{
    public interface ICarRepository : IRepository<Arac>
    {
        Task<IEnumerable<Arac>>GetCustomCarList();
        Task<Arac> GetCustomCar(int id);
    }
}

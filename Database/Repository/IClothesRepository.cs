using СlothingStore.API.Models;

namespace СlothingStore.API.Database.Repository
{
    public interface IClothesRepository
    {
        Task<Clothes> Create(Clothes clothes);
        Task<Clothes> GetByID(long id);
        Task<IEnumerable<Clothes>> GetAll();
        Task<Clothes> Update(Clothes clothes);
        Task<string> Delete(long id);
    }
}

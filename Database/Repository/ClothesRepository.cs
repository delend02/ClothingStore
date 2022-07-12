namespace СlothingStore.API.Database.Repository
{
    public class ClothesRepository : IClothesRepository
    {
        public Task<Clothes> Create(Clothes clothes)
        {
            throw new NotImplementedException();
        }

        public Task<string> Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Clothes>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Clothes> GetByID(long id)
        {
            throw new NotImplementedException();
        }

        public Task<Clothes> Update(Clothes clothes)
        {
            throw new NotImplementedException();
        }
    }
}

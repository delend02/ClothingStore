namespace СlothingStore.Database.Repository
{
    public class ClothesRepository : IRepository<Clothes>
    {
        public Task<Clothes> Create(Clothes entity)
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

        public Task<Clothes> Update(Clothes entity)
        {
            throw new NotImplementedException();
        }
    }
}

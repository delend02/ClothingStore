namespace СlothingStore.Database.Repository
{
    public interface IRepository<T>
        where T : class
    {
        Task<T> Create(T entity);
        Task<T> GetByID(long id);
        Task<IEnumerable<T>> GetAll();
        Task<T> Update(T entity);
        Task<string> Delete(long id);

    }
}

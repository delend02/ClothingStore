
namespace СlothingStore.API.Database.Repository
{
    public interface IUserRepository
    {
        Task<User> Create(User user);
        Task<User> GetByID(long id);
        Task<IEnumerable<UserDTO>> GetAll();
        Task<User> Update(User user);
        Task<string> Delete(long id);
    }
}

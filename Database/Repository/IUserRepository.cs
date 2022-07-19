using СlothingStore.API.Models.DTO;

namespace СlothingStore.API.Database.Repository
{
    public interface IUserRepository
    {
        Task Create(UserDTO user);
        Task<UsersInfoDTO> GetByID(long id);
        Task<IEnumerable<UsersInfoDTO>> GetAll();
        Task Update(UserDTO user);
        Task Delete(long id);
    }
}

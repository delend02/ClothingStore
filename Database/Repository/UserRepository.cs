namespace СlothingStore.API.Database.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly string connectionDB;
        public UserRepository(string connectionString)
        {
            connectionDB = connectionString ?? throw new ArgumentNullException(nameof(connectionString)); ;
        }

        public Task<User> Create(User user)
        {
            throw new NotImplementedException();
        }

        public Task<string> Delete(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<UserDTO>> GetAll()
        {
            using IDbConnection connection = new NpgsqlConnection(connectionDB);
            var sqlQuery = "SELECT id, nickname, login, password," +
                "cash FROM users";
            var result = await connection.QueryAsync<UserDTO>(sqlQuery);
            return result;
        }

        public Task<User> GetByID(long id)
        {
            throw new NotImplementedException();
        }

        public Task<User> Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}

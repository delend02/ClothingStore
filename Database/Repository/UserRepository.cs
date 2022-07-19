using Dapper;
using Npgsql;
using System.Data;
using СlothingStore.API.Models.DTO;

namespace СlothingStore.API.Database.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly string connectionDB;
        public UserRepository(string connectionString)
        {
            connectionDB = connectionString ?? throw new ArgumentNullException(nameof(connectionString)); ;
        }

        public async Task Create(UserDTO user)
        {
            using IDbConnection connection = new NpgsqlConnection(connectionDB);
            var sqlQuery = @"INSERT INTO public.users(
                            nickname, login, password, status)
	                        VALUES(@Nickname, @Login, @Password, 0);";
            await connection.ExecuteAsync(sqlQuery,
                new { user.Nickname,
                      user.Login,
                      user.Password });
        }

        public async Task Delete(long id)
        {
            using IDbConnection connection = new NpgsqlConnection(connectionDB);
            var sqlQuery = @"DELETE FROM users WHERE id = @id";
            await connection.ExecuteAsync(sqlQuery,
                new
                {
                    id
                });
        }

        public async Task<IEnumerable<UsersInfoDTO>> GetAll()
        {
            using IDbConnection connection = new NpgsqlConnection(connectionDB);
            var sqlQuery = @"SELECT 
                           id,
                           nickname,
                           login,
                           cash FROM users";
            var result = await connection.QueryAsync<UsersInfoDTO>(sqlQuery);
            return result;
        }

        public async Task<UsersInfoDTO> GetByID(long id)
        {
            using IDbConnection connection = new NpgsqlConnection(connectionDB);
            var sqlQuery = @"SELECT
                           id,
                           nickname,
                           login,
                           cash FROM users
                           WHERE id = @id";
            var result = await connection.QuerySingleOrDefaultAsync<UsersInfoDTO>(sqlQuery,
                                                                                  new { id });
            return result;
        }

        public async Task Update(UserDTO user)
        {
            using IDbConnection connection = new NpgsqlConnection(connectionDB);
            var sqlQuery = @"UPDATE public.users
	                        SET nickname = @nickname, login = @login, password = @password
	                        WHERE id = @id;";
            await connection.ExecuteAsync(sqlQuery,
                new
                {
                    user.Nickname,
                    user.Login,
                    user.Password,
                    user.ID
                });
        }
    }
}

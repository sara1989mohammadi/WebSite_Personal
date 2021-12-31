using Contracts.Repositories;
using Dapper;
using Entites;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Repository
{
    public class UserRepository : IUserRepository
    {
        #region Fields
        private readonly IConfiguration _configuration;
        #endregion

        #region Ctor
        public UserRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        #endregion

        #region Methods
        public async Task<int> AddAsync(Users users)
        {
            var sql = ("Insert Into Users(UserName,Password) VALUES (@UserName,@Password)");
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(sql, users);
                return result;
            }
        }

        public async Task<int> DeleteAsync(int id)
        {
            var sql = ("Delete From Users where Id=@Id");
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"))) 
            {
                connection.Open();
                var result = await connection.ExecuteAsync(sql, new { @Id = id });
                return result;
            }
        }

        public async Task<IReadOnlyList<Users>> GetAllAsync()
        {
            var sql = ("Select * From Users");
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.QueryAsync<Users>(sql);
                return result.ToList();
            }
        }

        public async Task<Users> GetByIdAsync(int id)
        {
            var sql = ("Select * From Users where Id=@Id");
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.QuerySingleOrDefaultAsync(sql, new { @Id = id });
                return result;
            }
        }

        public async Task<int> UpdateAsync(Users users)
        {
            var sql = ("Update Users UserName =@UserName ,Password=@Password");
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(sql, users);
                return result;
            }
        }
        #endregion
    }
}

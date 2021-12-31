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
    public class BiographyRepository : IBiographyRepository
    {
        #region Fields
        private readonly IConfiguration _configuration;
        #endregion

        #region Ctor
        public BiographyRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        #endregion

        #region Methods


        public async Task<int> AddAsync(Biography biography)
        {
            var sql = ("Insert Into Biography(Description) VALUES (@Description)");
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(sql, biography);
                return result;
            }
        }

        public async Task<int> DeleteAsync(int id)
        {
            var sql = ("Delete From Biography where Id=@Id");
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(sql, new { @Id = id });
                return result;
            }
        }

        public async Task<IReadOnlyList<Biography>> GetAllAsync()
        {
            var sql = ("Select * From Biography");
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.QueryAsync<Biography>(sql);
                return result.ToList();
            }
        }

        public async Task<Biography> GetByIdAsync(int id)
        {
            var sql = ("Select * From Biography where Id=@Id");
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.QuerySingleOrDefaultAsync(sql, new { @Id = id });
                return result;
            }
        }

        public async Task<int> UpdateAsync(Biography biography)
        {
            var sql = ("Update Biography Description=@Description");
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(sql, biography);
                return result;
            }
        }
        #endregion
    }
}

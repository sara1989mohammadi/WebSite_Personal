using Contracts.Repositories;
using Dapper;
using Entites;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.Repository
{
    public class ActivityRepository : IActivityRepository
    {
        #region Fields
        private readonly IConfiguration _configuration;
        #endregion

        #region Ctor
        public ActivityRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        #endregion

        #region Methods

        public async Task<int> AddAsync(Activity activity)
        {
            var sql = ("Insert Into Activity(Title) VALUES (@Title)");
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(sql, activity);
                return result;
            }
        }

        public async Task<int> DeleteAsync(int id)
        {
            var sql = ("Delete From Activity where Id=@Id");
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(sql, new { @Id = id });
                return result;
            }
        }

        public async Task<IReadOnlyList<Activity>> GetAllAsync()
        {
            var sql = ("Select * From Activity");
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.QueryAsync<Activity>(sql);
                return result.ToList();
            }
        }

        public async Task<Activity> GetByIdAsync(int id)
        {
            var sql = ("Select * From Activity where Id=@Id");
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.QuerySingleOrDefaultAsync(sql, new { @Id = id });
                return result;
            }
        }

        public async Task<int> UpdateAsync(Activity activity)
        {
            var sql = ("Update Activity Title=@Title");
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(sql, activity);
                return result;
            }
        }
        #endregion
    }
}

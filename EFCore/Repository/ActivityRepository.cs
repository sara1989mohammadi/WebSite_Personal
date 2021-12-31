using Contracts.Repositories;
using Dapper;
using Entites;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Activity>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Activity> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
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

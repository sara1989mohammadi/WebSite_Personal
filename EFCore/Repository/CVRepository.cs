using Contracts.Repositories;
using Dapper;
using Entites;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Repository
{
    public class CVRepository : ICVRepository
    {
        #region Fields
        private readonly IConfiguration _configuration;
        #endregion

        #region Ctor
        public CVRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        #endregion

        #region Methods


        public async Task<int> AddAsync(CV cv)
        {
            var sql = ("Insert Into CV(Title,University,Grade) VALUES (@Title,@University,@Grade)");
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(sql, cv);
                return result;
            }
        }

        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<CV>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CV> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<int> UpdateAsync(CV cv)
        {
            var sql = ("Update CV Title=@Title,University=@University,Grade=@Grade");
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(sql, cv);
                return result;
            }
        }
        #endregion
    }
}

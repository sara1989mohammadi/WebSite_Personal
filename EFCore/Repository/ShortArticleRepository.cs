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
    public class ShortArticleRepository : IShortArticleRepository
    {
        #region Fields
        private readonly IConfiguration _configuration;
        #endregion

        #region Ctor
        public ShortArticleRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        #endregion

        #region Methods


        public async Task<int> AddAsync(ShortArticle shortArticle)
        {
            var sql = ("Insert Into ShortArticle(Title,Description,FileUrl) VALUES (@Title,@Description,@FileUrl)");
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(sql, shortArticle);
                return result;
            }
        }

        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<ShortArticle>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ShortArticle> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<int> UpdateAsync(ShortArticle shortArticle)
        {
            var sql = ("Update Activity Title=@Title,Description=@Description,FileUrl=@FileUrl");
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(sql, shortArticle);
                return result;
            }
        }
        #endregion
    }
}

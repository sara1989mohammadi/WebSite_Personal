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

        public async Task<int> DeleteAsync(int id)
        {
            var sql = ("Delete From ShortArticle where Id=@Id");
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(sql, new { @Id = id });
                return result;
            }
        }

        public async Task<IReadOnlyList<ShortArticle>> GetAllAsync()
        {
            var sql = ("Select * From ShortArticle");
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.QueryAsync<ShortArticle>(sql);
                return result.ToList();
            }
        }

        public async Task<ShortArticle> GetByIdAsync(int id)
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

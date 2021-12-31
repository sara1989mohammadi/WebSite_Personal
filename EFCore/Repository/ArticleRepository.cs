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
    public class ArticleRepository : IArticleRepository
    {
        #region Fields
        private readonly IConfiguration _configuration;
        #endregion

        #region Ctor
        public ArticleRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        #endregion

        #region Methods
        public async Task<int> AddAsync(Article article)
        {
            var sql = ("Insert Into Article(Title,Description,FileUrl,Publisher,DatePublisher,ImageUrl) VALUES (@Title, @Description, @FileUrl, @Publisher, @DatePublisher, @ImageUrl)");
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(sql, article);
                return result;
            }
        }

        public async Task<int> DeleteAsync(int id)
        {
            var sql = ("Delete From Article where Id=@Id");
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(sql, new { @Id = id });
                return result;
            }
        }

        public async Task<IReadOnlyList<Article>> GetAllAsync()
        {
            var sql = ("Select * From Article");
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.QueryAsync<Article>(sql);
                return result.ToList();
            }
        }

        public async Task<Article> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<int> UpdateAsync(Activity article)
        {
            var sql = ("Update Article Title =@Title ,Description=@Description,FileUrl =@FileUrl ,Publisher=@Publisher,DatePublisher =@DatePublisher ,ImageUrl=@ImageUrl");
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(sql, article);
                return result;
            }
        }
        #endregion
    }
}

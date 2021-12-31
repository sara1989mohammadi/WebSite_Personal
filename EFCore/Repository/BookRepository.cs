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
    public class BookRepository : IBookRepository
    {
        #region Fields
        private readonly IConfiguration _configuration;
        #endregion

        #region Ctor
        public BookRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        #endregion

        #region Methods


        public async Task<int> AddAsync(Book book)
        {
            var sql = ("Insert Into Book(Name,Discription,Price,Author,Publisher,ISBN,ImageUrl)VALUES (@Name,@Discription,@Price,@Author,@Publisher,@ISBN,@ImageUrl)");
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(sql, book);
                return result;
            }
        }

        public async Task<int> DeleteAsync(int id)
        {
            var sql = ("Delete From Book where Id=@Id");
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(sql, new { @Id = id });
                return result;
            }
        }

        public async Task<IReadOnlyList<Book>> GetAllAsync()
        {
            var sql = ("Select * From Book");
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.QueryAsync<Book>(sql);
                return result.ToList();
            }
        }

        public async Task<Book> GetByIdAsync(int id)
        {
            var sql = ("Select * From Book where Id=@Id");
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.QuerySingleOrDefaultAsync(sql, new { @Id = id });
                return result;
            }
        }

        public async Task<int> UpdateAsync(Book book)
        {
            var sql = ("Update Book Name=@Name,Discription=@Discription,Price=@Price,Author=@Author,Publisher=@Publisher,ISBN=@ISBN,ImageUrl=@ImageUrl");
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(sql, book);
                return result;
            }
        }
        #endregion
    }
}

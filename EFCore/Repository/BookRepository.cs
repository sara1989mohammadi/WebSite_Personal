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

        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Book>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Book> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
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

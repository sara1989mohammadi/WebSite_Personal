using Contracts.Repositories;
using Entites;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
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


        public Task<int> AddAsync(Book book)
        {
            throw new NotImplementedException();
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

        public Task<int> UpdateAsync(Book book)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}

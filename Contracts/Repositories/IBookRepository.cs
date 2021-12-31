using Entites;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Repositories
{
    public interface IBookRepository
    {
        #region Methods
        Task<Book> GetByIdAsync(int id);
        Task<IReadOnlyList<Book>> GetAllAsync();
        Task<int> AddAsync(Book book);
        Task<int> UpdateAsync(Book book);
        Task<int> DeleteAsync(int id);
        #endregion
    }
}

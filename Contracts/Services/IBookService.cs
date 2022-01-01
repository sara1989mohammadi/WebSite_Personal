using Entites;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Services
{
    public interface IBookService
    {
        #region Methods
        Task<Book> GetById(int id);
        Task<IReadOnlyList<Book>> GetAll();
        Task<int> Add(Book book);
        Task<int> Update(Book book);
        Task<int> Delete(int id);
        #endregion
    }
}

using Entites;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Repositories
{
    public interface IArticleRepository
    {
        #region Methods
        Task<Article> GetByIdAsync(int id);
        Task<IReadOnlyList<Article>> GetAllAsync();
        Task<int> AddAsync(Article article);
        Task<int> UpdateAsync(Article article);
        Task<int> DeleteAsync(int id);
        #endregion
    }
}

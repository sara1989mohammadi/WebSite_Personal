using Entites;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Repositories
{
    public interface IShortArticleRepository
    {
        #region Methods
        Task<ShortArticle> GetByIdAsync(int id);
        Task<IReadOnlyList<ShortArticle>> GetAllAsync();
        Task<int> AddAsync(ShortArticle shortArticle);
        Task<int> UpdateAsync(ShortArticle shortArticle);
        Task<int> DeleteAsync(int id);
        #endregion
    }
}

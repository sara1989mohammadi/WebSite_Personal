using Entites;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Services
{
    public interface IShortArticleService
    {
        #region Methods
        Task<ShortArticle> GetById(int id);
        Task<IReadOnlyList<ShortArticle>> GetAll();
        Task<int> Add(ShortArticle shortArticle);
        Task<int> Update(ShortArticle shortArticle);
        Task<int> Delete(int id);
        #endregion
    }
}

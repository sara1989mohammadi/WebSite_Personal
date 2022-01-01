using Entites;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Services
{
 public   interface IArticleService
    {
        #region Methods
        Task<Article> GetById(int id);
        Task<IReadOnlyList<Article>> GetAll();
        Task<int> Add(Article article);
        Task<int> Update(Article article);
        Task<int> Delete(int id);
        #endregion
    }
}

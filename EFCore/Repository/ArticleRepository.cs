using Contracts.Repositories;
using Entites;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
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


        public Task<int> AddAsync(Article article)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Article>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Article> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(Activity article)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}

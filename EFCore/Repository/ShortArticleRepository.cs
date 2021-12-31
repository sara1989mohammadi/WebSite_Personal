using Contracts.Repositories;
using Entites;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Repository
{
    public class ShortArticleRepository : IShortArticleRepository
    {
        #region Fields
        private readonly IConfiguration _configuration;
        #endregion
        #region Ctor
        public ShortArticleRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        #endregion
        #region Methods


        public Task<int> AddAsync(ShortArticle shortArticle)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<ShortArticle>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ShortArticle> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(ShortArticle shortArticle)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}

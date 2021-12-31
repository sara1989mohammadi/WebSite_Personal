using Contracts.Repositories;
using Entites;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Repository
{
    public class CVRepository : ICVRepository
    {
        #region Fields
        private readonly IConfiguration _configuration;
        #endregion
        #region Ctor
        public CVRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        #endregion
        #region Methods


        public Task<int> AddAsync(CV cv)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<CV>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CV> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(CV cv)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}

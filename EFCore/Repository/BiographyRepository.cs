using Contracts.Repositories;
using Entites;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Repository
{
    public class BiographyRepository : IBiographyRepository
    {
        #region Fields
        private readonly IConfiguration _configuration;
        #endregion
        #region Ctor
        public BiographyRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        #endregion
        #region Methods


        public Task<int> AddAsync(Biography biography)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Biography>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Biography> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(Biography biography)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}

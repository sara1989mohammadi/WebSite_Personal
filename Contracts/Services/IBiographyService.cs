using Entites;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Services
{
    public interface IBiographyService
    {
        #region Methods
        Task<Biography> GetById(int id);
        Task<IReadOnlyList<Biography>> GetAll();
        Task<int> Add(Biography biography);
        Task<int> Update(Biography biography);
        Task<int> Delete(int id);
        #endregion
    }
}

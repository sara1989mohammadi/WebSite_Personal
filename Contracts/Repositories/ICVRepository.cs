using Entites;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Repositories
{
    public interface ICVRepository
    {
        #region Methods
        Task<CV> GetByIdAsync(int id);
        Task<IReadOnlyList<CV>> GetAllAsync();
        Task<int> AddAsync(CV cv);
        Task<int> UpdateAsync(CV cv);
        Task<int> DeleteAsync(int id);
        #endregion
    }
}

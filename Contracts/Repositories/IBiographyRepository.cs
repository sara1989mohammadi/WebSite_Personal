using Entites;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Contracts.Repositories
{
    public interface IBiographyRepository
    {
        #region Methods
        Task<Biography> GetByIdAsync(int id);
        Task<IReadOnlyList<Biography>> GetAllAsync();
        Task<int> AddAsync(Biography biography);
        Task<int> UpdateAsync(Biography biography);
        Task<int> DeleteAsync(int id);
        #endregion
    }
}

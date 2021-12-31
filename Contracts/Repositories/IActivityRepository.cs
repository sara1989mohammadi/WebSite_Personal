using Entites;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Contracts.Repositories
{
    public interface IActivityRepository
    {
        #region Methods
        Task<Activity> GetByIdAsync(int id);
        Task<IReadOnlyList<Activity>> GetAllAsync();
        Task<int> AddAsync(Activity activity);
        Task<int> UpdateAsync(Activity activity);
        Task<int> DeleteAsync(int id);
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Entites;

namespace Contracts.Repositories
{
    public interface IUserRepository
    {
        #region Methods
        Task<Users> GetByIdAsync(int id);
        Task<IReadOnlyList<Users>> GetAllAsync();
        Task<int> AddAsync(Users user);
        Task<int> UpdateAsync(Users user);
        Task<int> DeleteAsync(int id);
        #endregion
    }
}

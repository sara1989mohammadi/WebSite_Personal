using Entites;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Services
{
    public interface IUserService 
    {
        #region Methods
        Task<Users> GetById(int id);
        Task<IReadOnlyList<Users>> GetAll();
        Task<int> Add(Users user);
        Task<int> Update(Users user);
        Task<int> Delete(int id);
        #endregion
    }
}

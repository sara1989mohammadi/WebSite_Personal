using Entites;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Services
{
    public interface ICVService
    {
        #region Methods
        Task<CV> GetById(int id);
        Task<IReadOnlyList<CV>> GetAll();
        Task<int> Add(CV CV);
        Task<int> Update(CV cv);
        Task<int> Delete(int id);
        #endregion
    }
}

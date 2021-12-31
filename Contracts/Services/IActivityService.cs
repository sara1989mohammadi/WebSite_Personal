using Entites;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Services
{
  public  interface IActivityService
    {
        #region Methods
        Task<Activity> GetById(int id);
        Task<IReadOnlyList<Activity>> GetAll();
        Task<int> Add(Activity activity);
        Task<int> Update(Activity activity);
        Task<int> Delete(int id);
        #endregion
    }
}

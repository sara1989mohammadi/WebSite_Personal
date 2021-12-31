using Contracts;
using Contracts.Services;
using Entites;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ActivityService : IActivityService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ActivityService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<int> Add(Activity activity)
        {
            return await _unitOfWork.Activity.AddAsync(activity);
            _unitOfWork.Execute();
        }

        public async Task<int> Delete(int id)
        {
            return await _unitOfWork.Activity.DeleteAsync(id);
            _unitOfWork.Execute();
        }

        public async Task<IReadOnlyList<Activity>> GetAll()
        {
            return await _unitOfWork.Activity.GetAllAsync();
            _unitOfWork.Execute();
        }

        public async Task<Activity> GetById(int id)
        {
            return await _unitOfWork.Activity.GetByIdAsync(id);
            _unitOfWork.Execute();
        }

        public async Task<int> Update(Activity activity)
        {
            return await _unitOfWork.Activity.UpdateAsync(activity);
            _unitOfWork.Execute();
        }

         
    }
}

using Contracts;
using Contracts.Services;
using Entites;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class CVService: ICVService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CVService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<int> Add(CV cv)
        {
            return await _unitOfWork.Cv.AddAsync(cv);
            _unitOfWork.Execute();
        }

        public async Task<int> Delete(int id)
        {
            return await _unitOfWork.Cv.DeleteAsync(id);
            _unitOfWork.Execute();
        }

        public async Task<IReadOnlyList<CV>> GetAll()
        {
            return await _unitOfWork.Cv.GetAllAsync();
            _unitOfWork.Execute();
        }

        public async Task<CV> GetById(int id)
        {
            return await _unitOfWork.Cv.GetByIdAsync(id);
            _unitOfWork.Execute();
        }

        public async Task<int> Update(CV CV)
        {
            return await _unitOfWork.Cv.UpdateAsync(CV);
            _unitOfWork.Execute();
        }
    }
}

using Contracts;
using Contracts.Services;
using Entites;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class BiographyService: IBiographyService
    {
        private readonly IUnitOfWork _unitOfWork;

        public BiographyService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<int> Add(Biography biography)
        {
            return await _unitOfWork.Biography.AddAsync(biography);
            _unitOfWork.Execute();
        }

        public async Task<int> Delete(int id)
        {
            return await _unitOfWork.Biography.DeleteAsync(id);
            _unitOfWork.Execute();
        }

        public async Task<IReadOnlyList<Biography>> GetAll()
        {
            return await _unitOfWork.Biography.GetAllAsync();
            _unitOfWork.Execute();
        }

        public async Task<Biography> GetById(int id)
        {
            return await _unitOfWork.Biography.GetByIdAsync(id);
            _unitOfWork.Execute();
        }

        public async Task<int> Update(Biography biography)
        {
            return await _unitOfWork.Biography.UpdateAsync(biography);
            _unitOfWork.Execute();
        }
    }
}

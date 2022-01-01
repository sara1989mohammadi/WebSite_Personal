using Contracts;
using Contracts.Services;
using Entites;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ShortArticleService: IShortArticleService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ShortArticleService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<int> Add(ShortArticle shortArticle)
        {
            return await _unitOfWork.ShortArticle.AddAsync(shortArticle);
            _unitOfWork.Execute();
        }

        public async Task<int> Delete(int id)
        {
            return await _unitOfWork.ShortArticle.DeleteAsync(id);
            _unitOfWork.Execute();
        }

        public async Task<IReadOnlyList<ShortArticle>> GetAll()
        {
            return await _unitOfWork.ShortArticle.GetAllAsync();
            _unitOfWork.Execute();
        }

        public async Task<ShortArticle> GetById(int id)
        {
            return await _unitOfWork.ShortArticle.GetByIdAsync(id);
            _unitOfWork.Execute();
        }

        public async Task<int> Update(ShortArticle shortArticle)
        {
            return await _unitOfWork.ShortArticle.UpdateAsync(shortArticle);
            _unitOfWork.Execute();
        }
    }
}

using Contracts;
using Contracts.Services;
using Entites;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
 public   class ArticleService: IArticleService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ArticleService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<int> Add(Article article)
        {
            return await _unitOfWork.Article.AddAsync(article);
            _unitOfWork.Execute();
        }

        public async Task<int> Delete(int id)
        {
            return await _unitOfWork.Article.DeleteAsync(id);
            _unitOfWork.Execute();
        }

        public async Task<IReadOnlyList<Article>> GetAll()
        {
            return await _unitOfWork.Article.GetAllAsync();
            _unitOfWork.Execute();
        }

        public async Task<Article> GetById(int id)
        {
            return await _unitOfWork.Article.GetByIdAsync(id);
            _unitOfWork.Execute();
        }

        public async Task<int> Update(Article article)
        {
            return await _unitOfWork.Article.UpdateAsync(article);
            _unitOfWork.Execute();
        }
    }
}

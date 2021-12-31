using Contracts;
using Entites;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Controllers
{
    public class ArticleController : Controller
    {
        #region Fields
        private readonly IUnitOfWork _unitOfWork;
        #endregion

        #region Ctor
        public ArticleController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        #endregion

        #region Methods      

        public async Task<IActionResult> GetAll()
        {
            var model = await _unitOfWork.Article.GetAllAsync();
            return View(model);
        }

        public async Task<IActionResult> GetById(int id)
        {
            var model = await _unitOfWork.Article.GetByIdAsync(id);
            return View(model);
        }
        public async Task<IActionResult> Add(Article article)
        {
            var model = await _unitOfWork.Article.AddAsync(article);
            return View(model);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var model = await _unitOfWork.Article.DeleteAsync(id);
            return View(model);
        }
        public async Task<IActionResult> Update(Article article)
        {
            var model = await _unitOfWork.Article.UpdateAsync(article);
            return Ok(model);
        }
        #endregion
    }
}

using Contracts;
using Entites;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Admin.Controllers
{
    public class ShortArticleController : Controller
    {
        #region Fields
        private readonly IUnitOfWork _unitOfWork;
        #endregion

        #region Ctor
        public ShortArticleController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        #endregion

        #region Methods      

        public async Task<IActionResult> GetAll()
        {
            var model = await _unitOfWork.ShortArticle.GetAllAsync();
            return View(model);
        }

        public async Task<IActionResult> GetById(int id)
        {
            var model = await _unitOfWork.ShortArticle.GetByIdAsync(id);
            return View(model);
        }
        public async Task<IActionResult> Add(ShortArticle shortArticle)
        {
            var model = await _unitOfWork.ShortArticle.AddAsync(shortArticle);
            return View(model);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var model = await _unitOfWork.ShortArticle.DeleteAsync(id);
            return View(model);
        }
        public async Task<IActionResult> Update(ShortArticle shortArticle)
        {
            var model = await _unitOfWork.ShortArticle.UpdateAsync(shortArticle);
            return Ok(model);
        }
        #endregion
    }
}

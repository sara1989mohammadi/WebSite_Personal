using Contracts;
using Entites;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Admin.Controllers
{
    public class BiographyController : Controller
    {
        #region Fields
        private readonly IUnitOfWork _unitOfWork;
        #endregion

        #region Ctor
        public BiographyController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        #endregion
        #region Methods      

        public async Task<IActionResult> GetAll()
        {
            var model = await _unitOfWork.Biography.GetAllAsync();
            return View(model);
        }

        public async Task<IActionResult> GetById(int id)
        {
            var model = await _unitOfWork.Biography.GetByIdAsync(id);
            return View(model);
        }
        public async Task<IActionResult> Add(Biography biography)
        {
            var model = await _unitOfWork.Biography.AddAsync(biography);
            return View(model);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var model = await _unitOfWork.Biography.DeleteAsync(id);
            return View(model);
        }
        public async Task<IActionResult> Update(Biography biography)
        {
            var model = await _unitOfWork.Biography.UpdateAsync(biography);
            return Ok(model);
        }
        #endregion
    }
}

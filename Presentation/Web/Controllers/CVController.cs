using Contracts;
using Entites;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Controllers
{
    public class CVController : Controller
    {
        #region Fields
        private readonly IUnitOfWork _unitOfWork;
        #endregion

        #region Ctor
        public CVController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        #endregion

        #region Methods      

        public async Task<IActionResult> GetAll()
        {
            var model = await _unitOfWork.Cv.GetAllAsync();
            return View(model);
        }

        public async Task<IActionResult> GetById(int id)
        {
            var model = await _unitOfWork.Cv.GetByIdAsync(id);
            return View(model);
        }
        public async Task<IActionResult> Add(CV cv)
        {
            var model = await _unitOfWork.Cv.AddAsync(cv);
            return View(model);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var model = await _unitOfWork.Cv.DeleteAsync(id);
            return View(model);
        }
        public async Task<IActionResult> Update(CV cv)
        {
            var model = await _unitOfWork.Cv.UpdateAsync(cv);
            return Ok(model);
        }
        #endregion
    }
}

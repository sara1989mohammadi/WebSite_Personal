using Contracts;
using Entites;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Admin.Controllers
{
    public class BookController : Controller
    {
        #region Fields
        private readonly IUnitOfWork _unitOfWork;
        #endregion

        #region Ctor
        public BookController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        #endregion

        #region Methods      

        public async Task<IActionResult> GetAll()
        {
            var model = await _unitOfWork.Book.GetAllAsync();
            return View(model);
        }

        public async Task<IActionResult> GetById(int id)
        {
            var model = await _unitOfWork.Book.GetByIdAsync(id);
            return View(model);
        }
        public async Task<IActionResult> Add(Book book)
        {
            var model = await _unitOfWork.Book.AddAsync(book);
            return View(model);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var model = await _unitOfWork.Book.DeleteAsync(id);
            return View(model);
        }
        public async Task<IActionResult> Update(Book book)
        {
            var model = await _unitOfWork.Book.UpdateAsync(book);
            return Ok(model);
        }
        #endregion
    }
}

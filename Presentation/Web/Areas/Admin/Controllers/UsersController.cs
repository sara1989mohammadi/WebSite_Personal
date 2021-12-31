using Contracts;
using Entites;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Admin.Controllers
{
    public class UsersController : Controller
    {
        #region Fields
        private readonly IUnitOfWork _unitOfWork;
        #endregion

        #region Ctor
        public UsersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        #endregion

        #region Methods      

        public async Task<IActionResult> GetAll()
        {
            var model = await _unitOfWork.Users.GetAllAsync();
            return View(model);
        }

        public async Task<IActionResult> GetById(int id)
        {
            var model = await _unitOfWork.Users.GetByIdAsync(id);
            return View(model);
        }
        public async Task<IActionResult> Add(Users users)
        {
            var model = await _unitOfWork.Users.AddAsync(users);
            return View(model);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var model = await _unitOfWork.Users.DeleteAsync(id);
            return View(model);
        }
        public async Task<IActionResult> Update(Users users)
        {
            var model = await _unitOfWork.Users.UpdateAsync(users);
            return Ok(model);
        }
        #endregion
    }
}

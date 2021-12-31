﻿using Contracts;
using Entites;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Controllers
{
    public class ActivityController : Controller
    {
        #region Fields
        private readonly IUnitOfWork _unitOfWork;
        #endregion

        #region Ctor
        public ActivityController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        #endregion

        #region Methods      

        public async Task<IActionResult> GetAll()
        {
            var model =await _unitOfWork.Activity.GetAllAsync();
            return View(model);
        }

        public async Task<IActionResult> GetById(int id)
        {
            var model = await _unitOfWork.Activity.GetByIdAsync(id);
            return View(model);
        }
        public async Task<IActionResult> Add(Activity activity)
        {
            var model = await _unitOfWork.Activity.AddAsync(activity);
            return View(model);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var model = await _unitOfWork.Activity.DeleteAsync(id);
            return View(model);
        }
        public async Task<IActionResult> Update(Activity activity)
        {
            var model = await _unitOfWork.Activity.UpdateAsync(activity);
            return Ok(model);
        }
        #endregion
    }
}

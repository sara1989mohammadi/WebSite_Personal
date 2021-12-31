using Contracts;
using Contracts.Services;
using Entites;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Admin.Controllers
{
    public class ActivityController : Controller
    {
        #region Fields
        private readonly IActivityService _activityService;
        #endregion

        #region Ctor
        public ActivityController( IActivityService activityService)
        {           
            _activityService = activityService;
        }
        #endregion

        #region Methods      

        public async Task<IActionResult> GetAll()
        {
            var model =await _activityService.GetAll();
            return View(model);
        }

        public async Task<IActionResult> GetById(int id)
        {
            var model = await _activityService.GetById(id);
            return View(model);
        }
        public async Task<IActionResult> Add(Activity activity)
        {
            var model =await _activityService.Add(activity);
            return View(model);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var model = await _activityService.Delete(id);
            return View(model);
        }
        public async Task<IActionResult> Update(Activity activity)
        {
            var model = await _activityService.Update(activity);
            return Ok(model);
        }
        #endregion
    }
}

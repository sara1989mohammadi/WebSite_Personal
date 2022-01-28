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
    public class ActivityController : BaseController
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

        public async Task<IActionResult> Index()
        {
            var model =await _activityService.GetAll();
            return View(model);
        }

        public async Task<IActionResult> GetById(int id)
        {
            var model = await _activityService.GetById(id);
            return View(model);
        }
        public async Task<IActionResult> Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(Activity activity)
        {
            var model = await _activityService.Add(activity);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int id)
        {
            var model = await _activityService.Delete(id);
            return View(model);
        }
        public async Task<IActionResult> Update()
        {
            return Ok();
        }
        public async Task<IActionResult> Update(Activity activity)
        {
            var model = await _activityService.Update(activity);
            return RedirectToAction(nameof(Index));
        }
        #endregion
    }
}

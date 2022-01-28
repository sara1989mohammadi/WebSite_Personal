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
    public class BiographyController : BaseController
    {
        #region Fields
        private readonly IBiographyService _biographyService;
        #endregion

        #region Ctor
        public BiographyController(IBiographyService biographyService)
        {
            _biographyService = biographyService;
        }
        #endregion
        #region Methods      
        public async Task<IActionResult> Index()
        {
            var model = await _biographyService.GetAll();
            return View(model);
        }

        public async Task<IActionResult> Add()
        {
            return View();

        }
        [HttpPost]
            public async Task<IActionResult> Add(Biography biography)
            {
            var model = await _biographyService.Add(biography);
                return RedirectToAction(nameof(Index));
        }
            #endregion
        }
}

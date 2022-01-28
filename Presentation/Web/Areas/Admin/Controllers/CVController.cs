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
    public class CVController : BaseController
    {
        #region Fields
        private readonly ICVService _cvService ;
        #endregion

        #region Ctor
        public CVController(ICVService cvService)
        {
            _cvService = cvService;
        }
        #endregion

        #region Methods      
        public async Task<IActionResult> Index()
        {
            var model = await _cvService.GetAll();
            return View(model);
        }


        #endregion
    }
}

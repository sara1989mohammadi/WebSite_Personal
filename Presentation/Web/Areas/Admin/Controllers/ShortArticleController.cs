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
    public class ShortArticleController : BaseController
    {
        #region Fields
        private readonly IShortArticleService _shortArticleService;
        #endregion

        #region Ctor
        public ShortArticleController(IShortArticleService shortArticleService)
        {
            _shortArticleService = shortArticleService;
        }
        #endregion

        #region Methods      
        public async Task<IActionResult> Index()
        {
            var model = await _shortArticleService.GetAll();
            return View(model);
        }
        #endregion
    }
}

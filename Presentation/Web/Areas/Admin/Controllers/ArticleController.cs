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
    public class ArticleController : BaseController
    {
        #region Fields
        private readonly IArticleService _articleService;
        #endregion

        #region Ctor
        public ArticleController(IArticleService articleService)
        {
            _articleService = articleService;
        }
        #endregion

        #region Methods      
        public async Task<IActionResult> Index()
        {
            var model = await _articleService.GetAll();
            return View(model);
        }

        #endregion
    }
}

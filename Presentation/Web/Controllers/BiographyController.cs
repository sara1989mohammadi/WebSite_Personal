using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Controllers
{
    public class BiographyController : Controller
    {
        #region Fields
        #endregion

        #region Ctor
        #endregion
        #region Methods
        public IActionResult Index()
        {
            return View();
        }
        #endregion
    }
}

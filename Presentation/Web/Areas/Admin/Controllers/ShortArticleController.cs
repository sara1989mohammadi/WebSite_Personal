using Contracts;
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
        private readonly IUnitOfWork _unitOfWork;
        #endregion

        #region Ctor
        public ShortArticleController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        #endregion

        #region Methods      

        #endregion
    }
}

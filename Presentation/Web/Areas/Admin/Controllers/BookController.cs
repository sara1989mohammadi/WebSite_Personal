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
    public class BookController : BaseController
    {
        #region Fields
        private readonly IBookService _bookService;
        #endregion

        #region Ctor
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }
        #endregion

        #region Methods      

        public async Task<IActionResult> Index()
        {
            var model = await _bookService.GetAll();
            return View(model);
        }

        public async Task<IActionResult> Add()
        {
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> Add(Book book)
        {
            var model = await _bookService.Add(book);
            return RedirectToAction(nameof(Index));
        }
        #endregion
    }
}

using BookStore.Repositories.Contracts;
using BookStore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.Controllers
{
    [RoutePrefix("livros")]
    public class LivroController : Controller
    {
        private ICategoryRepository _categoryRepository;

        public LivroController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }


        [Route("criar")]
        public ActionResult Create()
        {
            var categorias = _categoryRepository.Get();
            var model = new CreateBookViewModel
            {
                Nome = "",
                ISBN = "",
                CategoriaId = 0,
                CategoriaOption = new SelectList(categorias, "Id", "Nome")
            };

            return View(model);
        }

        [Route("criar")]
        [HttpPost]
        public ActionResult Create(CreateBookViewModel model)
        {
            return View();
        }
    }
}
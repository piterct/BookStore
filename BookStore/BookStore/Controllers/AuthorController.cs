using BookStore.Domain.Entities;
using BookStore.Domain.Services.Contracts;
using BookStore.Repositories.Contracts;
using System.Web.Mvc;
using System.Web.Routing;

namespace BookStore.Controllers
{
    [RoutePrefix("autores")]
    //[LogActionFilter()]
    public class AuthorController : Controller
    {

        private readonly IAuthorRepository _repository;

        private readonly IAuthorService _service;
        public AuthorController(IAuthorRepository repository, IAuthorService service)
        {
            _repository = repository;
            _service = service;
        }

        [Route("listar")]
        public ActionResult Index()
        {
            var autores = _repository.Get();
            return View(autores);
        }

        [Route("criar")]
        public ActionResult Create()
        {
            return View();
        }

        [Route("criar")]
        [HttpPost]
        public ActionResult Create(Autor author)
        {
            if (_repository.Create(author))
            {
                return RedirectToAction("Index");
            }

            return View(author);
        }

        [Route("editar/{id:int}")]
        public ActionResult Edit(int id)
        {
            var author = _repository.Get(id);
            return View(author);
        }

        [Route("editar/{id:int}")]
        [HttpPost]
        public ActionResult Edit(Autor author)
        {
            if (_repository.Update(author))
            {
                return RedirectToAction("Index");
            }

            return View(author);
        }

        [Route("excluir/{id:int}")]
        public ActionResult Delete(int id)
        {
            var author = _repository.Get(id);
            return View(author);
        }

        [Route("excluir/{id:int}")]
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            _repository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
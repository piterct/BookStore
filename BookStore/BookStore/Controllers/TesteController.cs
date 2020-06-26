using BookStore.Domain;
using System.Web.Mvc;
using System.Web.Routing;

namespace BookStore.Controllers
{
    [RoutePrefix("Teste")]
    [Route("{action=Dados}")]
    public class TesteController : Controller
    {
        public ViewResult Dados(int Id)
        {
            var autor = new Autor
            {
                Id = 1,
                Nome = "Michael Peter"
            };

            ViewBag.Categoria = "Produtos de Limpeza";
            ViewData["Categoria"] = "Produtos de Informática";
            TempData["Categoria"] = "Produtos de Escritório";
            Session["Categoria"] = "Móveis";

            return View(autor);
        }

        public string Index(int Id)
        {
            return "Rota Default";
        }

        public JsonResult UmaAction(int id, string nome)
        {

            var autor = new Autor
            {
                Id = id,
                Nome = nome
            };

            return Json(autor, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [ActionName("Autor")]
        public JsonResult ActionDois(Autor autor)
        {
            return Json(autor);
        }

        [Route("minharota/{id:int}")]
        public string MinhaAction(int id)
        {
            return "Ok! Cheguei na rota!";
        }

        [Route("~/rotaignorada/{id:int}")]
        public string MinhaAction2(int id)
        {
            return "Ok! Cheguei na rota ignorada!";
        }

        [Route("rotarestrita/{categoria:alpha:minLength(3)}")]
        public string MinhaAction3(string categoria)
        {
            return "Ok! Cheguei na rota restrita! " + categoria;
        }

    }
}
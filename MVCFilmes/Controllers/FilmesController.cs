using Microsoft.AspNetCore.Mvc;

namespace MVCFilmes.Controllers
{
    public class FilmesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BemVindo(string nome)
        {
            return View();
        }
    
    
    }

}

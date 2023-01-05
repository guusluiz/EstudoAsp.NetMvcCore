using Microsoft.AspNetCore.Mvc;
using MinhaDemoMvc.Models;
using System.Diagnostics;

namespace MinhaDemoMvc.Controllers
{
    //[Route("")]
    //[Route("gestao")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        //[Route("")]
        //[Route("pagina-inicial")]
        //[Route("pagina-inicial/{id:int}/{categoria:guid}")]
        public IActionResult Index(int id, Guid categoria)
        {
            var filme = new Filme
            {
                Titulo = "oi",
                DataLancamento = DateTime.Now,
                Genero = null,
                Avaliacao = 10,
                Valor = 20000
            };
            return RedirectToAction("Privacy", filme);
            //return View();
        }
        //[Route("privacidade")]
        //[Route("politica-de-privacidade")]
        public IActionResult Privacy(Filme filme)
        {
            if(ModelState.IsValid)
            {

            }
        
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //[Route("erro")]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using HELLO_WORLD.Models;
namespace HELLO_WORLD.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Tiempos tiempo = new Tiempos();
            tiempo.tiempo = DateTime.Now;
            return View(tiempo);
        }
    }
}

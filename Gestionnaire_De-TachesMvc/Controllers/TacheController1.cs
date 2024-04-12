using Gestionnaire_De_TachesMvc.Services;
using Microsoft.AspNetCore.Mvc;

namespace Gestionnaire_De_TachesMvc.Controllers
{
    public class TacheController1 : Controller
    {
        private readonly ITacheServices tacheServices;

        public TacheController1(ITacheServices tacheServices)
        {
            this.tacheServices = tacheServices;
        }

        [HttpGet]

        public IActionResult GetAll()
        {
            var getTaches =tacheServices.GetTaches();
            if(getTaches == null || !getTaches.Any()) {
                return NotFound();
            }
            return View(getTaches);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}

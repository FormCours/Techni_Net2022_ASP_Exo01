using Demo_ASP_MVC_Exo01.Data;
using Demo_ASP_MVC_Exo01.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo_ASP_MVC_Exo01.Controllers
{
    public class HouseController : Controller
    {
        public IActionResult Index()
        {
            // La liste des maisons
            IEnumerable<House> houses = FakeDB.Houses;

            // Envoi des données via le modele de vue
            return View(houses);
        }

        public IActionResult Detail([FromRoute]int id)
        {
            // Detail d'une maison
            House? house = FakeDB.Houses.SingleOrDefault(h => h.Id == id);

            // TODO Not found !!!

            return View(house);
        }
    }
}

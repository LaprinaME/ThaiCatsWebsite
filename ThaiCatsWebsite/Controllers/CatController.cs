using Microsoft.AspNetCore.Mvc;
using ThaiCatsWebsite.Models;

namespace ThaiCatsWebsite.Controllers
{
    public class CatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateRezult(string breed, string weight, string color)
        {
            // Сохраняем введенные данные в статическом классе
            CatStorage.SaveCat(breed, weight, color);

            return RedirectToAction("Rezult");
        }

        public IActionResult Rezult()
        {
            // Получаем сохраненные данные из статического класса
            Cat model = CatStorage.GetCat();

            return View(model);
        }
    }
}

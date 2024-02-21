// ThaiCatsWebsite/Controllers/HomeController.cs
using Microsoft.AspNetCore.Mvc;
using ThaiCatsWebsite.ViewModels;


namespace ThaiCatsWebsite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var viewModel = new HomeIndexViewModel
            {
                //Title = "Добро пожаловать на сайт «ThaiCatsWebsite»!"
                //Content = "У котят есть очень странная привычка… что бы вы им ни сказали, они всегда отвечают “муррр”, — Льюис Кэрролл, писатель."
            };

            return View(viewModel);
        }

        public IActionResult Origin()
        {
            return RedirectToAction("Index", "Origin");
        }

        public IActionResult Character()
        {
            return RedirectToAction("Index", "Character");
        }

        public IActionResult Care()
        {
            return RedirectToAction("Index", "Care");
        }
    }
}

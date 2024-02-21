// ThaiCatsWebsite/Controllers/CharacterController.cs
using Microsoft.AspNetCore.Mvc;
using ThaiCatsWebsite.ViewModels;

namespace ThaiCatsWebsite.Controllers
{
    public class CharacterController : Controller
    {
        public IActionResult Index()
        {
            var viewModel = new CharacterIndexViewModel
            {
                Title = "Character of Thai Cats",
                CharacterInfo = "Learn about the typical character traits of Thai cats."
            };

            return View(viewModel);
        }
    }
}

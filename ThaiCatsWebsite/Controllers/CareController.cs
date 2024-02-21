// ThaiCatsWebsite/Controllers/CareController.cs
using Microsoft.AspNetCore.Mvc;
using ThaiCatsWebsite.ViewModels;

namespace ThaiCatsWebsite.Controllers
{
    public class CareController : Controller
    {
        public IActionResult Index()
        {
            var viewModel = new CareIndexViewModel
            {
                Title = "Care for Thai Cats",
                CareInfo = "Information on how to care for your Thai cat."
            };

            return View(viewModel);
        }
    }
}

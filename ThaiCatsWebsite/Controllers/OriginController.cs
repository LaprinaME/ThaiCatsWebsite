// ThaiCatsWebsite/Controllers/OriginController.cs
using Microsoft.AspNetCore.Mvc;
using ThaiCatsWebsite.ViewModels;


namespace ThaiCatsWebsite.Controllers
{
    public class OriginController : Controller
    {
        public IActionResult Index()
        {
            var viewModel = new OriginIndexViewModel
            {
                Title = "Origin of Thai Cats",
                OriginInfo = "Information about the origin of Thai cats goes here."
            };

            return View(viewModel);
        }
    }
}

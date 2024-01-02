using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OutputCaching;
using NowonMedical.Models;

namespace NowonMedical.Controllers
{
    public class CommunityController : Controller
    {
        [Route("/community/notice")]
        public IActionResult Notice()
        {
            NavigatorModel navigator = new NavigatorModel(2, 0);
            ViewData["banner_url"] = "../assets/images/intro_background_menu3.png";
            return View(navigator);
        }

        [Route("/community/review")]
        public IActionResult Review()
        {
            NavigatorModel navigator = new NavigatorModel(2, 1);
            ViewData["banner_url"] = "../assets/images/intro_background_menu3.png";
            return View(navigator);
        }

        [Route("/community/news")]
        public IActionResult News()
        {
            NavigatorModel navigator = new NavigatorModel(2, 2);
            ViewData["banner_url"] = "../assets/images/intro_background_menu3.png";
            return View(navigator);
        }
    }
}

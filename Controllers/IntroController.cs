using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OutputCaching;
using NowonMedical.Models;

namespace NowonMedical.Controllers
{
    public class IntroController : Controller
    {
        [Route("/intro/cover")]
        public IActionResult Cover()
        {
            NavigatorModel navigator = new NavigatorModel(0, 0);
            ViewData["banner_url"] = "../assets/images/intro_background_menu1.png";
			ViewData["main_banner_url"] = "../assets/images/intro_background.png";

			return View(navigator);
        }

        [Route("/intro/figure")]
        public IActionResult Figure()
        {
            NavigatorModel navigator = new NavigatorModel(0, 1);
            ViewData["banner_url"] = "../assets/images/intro_background_menu1.png";
			ViewData["main_banner_url"] = "../assets/images/intro_background.png";

			return View(navigator);
        }

        [Route("/intro/path")]
        public IActionResult Path()
        {
            NavigatorModel navigator = new NavigatorModel(0, 2);
            ViewData["banner_url"] = "../assets/images/intro_background_menu1.png";
			ViewData["main_banner_url"] = "../assets/images/intro_background.png";

			return View(navigator);
        }

        [Route("/intro/time")]
        public IActionResult Time()
        {
            NavigatorModel navigator = new NavigatorModel(0, 3);
            ViewData["banner_url"] = "../assets/images/intro_background_menu1.png";
			ViewData["main_banner_url"] = "../assets/images/intro_background.png";

			return View(navigator);
        }
    }
}

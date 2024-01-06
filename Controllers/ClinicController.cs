using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OutputCaching;
using NowonMedical.Models;

namespace NowonMedical.Controllers
{
    public class ClinicController : Controller
    {
        [Route("/clinic/spine")]
        public IActionResult Spine()
        {
			ViewBag.Navigator = new NavigatorModel(1, 0);
            ViewData["banner_url"] = "../assets/images/intro_background_menu2.png";
            ViewData["main_banner_url"] = "../assets/images/intro_background.png";
			
			return View();
        }

        [Route("/clinic/joint")]
        public IActionResult Joint()
        {
			ViewBag.Navigator = new NavigatorModel(1, 1);
            ViewData["banner_url"] = "../assets/images/intro_background_menu2.png";
			ViewData["main_banner_url"] = "../assets/images/intro_background.png";

			return View();
        }

        [Route("/clinic/nerve")]
        public IActionResult Nerve()
        {
			ViewBag.Navigator = new NavigatorModel(1, 2);
            ViewData["banner_url"] = "../assets/images/intro_background_menu2.png";
			ViewData["main_banner_url"] = "../assets/images/intro_background.png";

			return View();
        }

        [Route("/clinic/therapy")]
        public IActionResult therapy()
        {
			ViewBag.Navigator = new NavigatorModel(1, 3);
            ViewData["banner_url"] = "../assets/images/intro_background_menu2.png";
			ViewData["main_banner_url"] = "../assets/images/intro_background.png";

			return View();
        }

        [Route("/clinic/wave")]
        public IActionResult Wave()
        {
			ViewBag.Navigator = new NavigatorModel(1, 4);
            ViewData["banner_url"] = "../assets/images/intro_background_menu2.png";
			ViewData["main_banner_url"] = "../assets/images/intro_background.png";

			return View();
        }

        [Route("/clinic/retain")]
        public IActionResult Retain()
        {
			ViewBag.Navigator = new NavigatorModel(1, 5);
            ViewData["banner_url"] = "../assets/images/intro_background_menu2.png";
			ViewData["main_banner_url"] = "../assets/images/intro_background.png";

			return View();
        }
    }
}

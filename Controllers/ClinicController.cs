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
            NavigatorModel navigator = new NavigatorModel(1, 0);
            ViewData["banner_url"] = "../assets/images/intro_background_menu2.png";
            return View(navigator);
        }

        [Route("/clinic/joint")]
        public IActionResult Joint()
        {
            NavigatorModel navigator = new NavigatorModel(1, 1);
            ViewData["banner_url"] = "../assets/images/intro_background_menu2.png";
            return View(navigator);
        }

        [Route("/clinic/nerve")]
        public IActionResult Nerve()
        {
            NavigatorModel navigator = new NavigatorModel(1, 2);
            ViewData["banner_url"] = "../assets/images/intro_background_menu2.png";
            return View(navigator);
        }

        [Route("/clinic/therapy")]
        public IActionResult therapy()
        {
            NavigatorModel navigator = new NavigatorModel(1, 3);
            ViewData["banner_url"] = "../assets/images/intro_background_menu2.png";
            return View(navigator);
        }

        [Route("/clinic/wave")]
        public IActionResult Wave()
        {
            NavigatorModel navigator = new NavigatorModel(1, 4);
            ViewData["banner_url"] = "../assets/images/intro_background_menu2.png";
            return View(navigator);
        }

        [Route("/clinic/retain")]
        public IActionResult Retain()
        {
            NavigatorModel navigator = new NavigatorModel(1, 5);
            ViewData["banner_url"] = "../assets/images/intro_background_menu2.png";
            return View(navigator);
        }
    }
}

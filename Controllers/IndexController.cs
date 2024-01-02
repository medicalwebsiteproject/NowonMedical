using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OutputCaching;
using NowonMedical.Models;
using System.Diagnostics;

namespace NowonMedical.Controllers
{
    public class IntroController : Controller
    {
        [OutputCache(NoStore = true, Duration = 0)]
        public IActionResult Index()
        {
            return View();
        }

        [Route("Test")]
        public IActionResult Test()
        {
            NavigatorModel navigator = new NavigatorModel(1, 2);
            ViewData["banner_url"] = "../assets/images/intro_background_menu1.png";
            return View(navigator);
        }

        [Route("")]
        [Route("Intro")]
        [Route("Intro/Cover")]
        public IActionResult Cover()
        {
            NavigatorModel navigator = new NavigatorModel(0, 0);
            ViewData["banner_url"] = "../assets/images/intro_background_menu1.png";
            return View(navigator);
        }
        [Route("Intro/Figure")]
        public IActionResult Figure()
        {
            NavigatorModel navigator = new NavigatorModel(0, 1);
            ViewData["banner_url"] = "../assets/images/intro_background_menu1.png";
            return View(navigator);
        }

        [Route("Intro/Path")]
        public IActionResult Path()
        {
            NavigatorModel navigator = new NavigatorModel(0, 2);
            ViewData["banner_url"] = "../assets/images/intro_background_menu1.png";
            return View(navigator);
        }

        [Route("Intro/Time")]
        public IActionResult Time()
        {
            NavigatorModel navigator = new NavigatorModel(0, 3);
            ViewData["banner_url"] = "../assets/images/intro_background_menu1.png";
            return View(navigator);
        }
    }
    public class ClinicController : Controller
    {
        [OutputCache(NoStore = true, Duration = 0)]
        [Route("")]
        [Route("Clinic")]
        [Route("Clinic/Spine")]

        public IActionResult Spine()
        {
            NavigatorModel navigator = new NavigatorModel(1, 0);
            ViewData["banner_url"] = "../assets/images/intro_background_menu2.png";
            return View(navigator);
        }

        [Route("Clinic/Joint")]
        public IActionResult Joint()
        {
            NavigatorModel navigator = new NavigatorModel(1, 1);
            ViewData["banner_url"] = "../assets/images/intro_background_menu2.png";
            return View(navigator);
        }

        [Route("Clinic/Nerve")]
        public IActionResult Nerve()
        {
            NavigatorModel navigator = new NavigatorModel(1, 2);
            ViewData["banner_url"] = "../assets/images/intro_background_menu2.png";
            return View(navigator);
        }

        [Route("Clinic/Dosu")]
        public IActionResult Dosu()
        {
            NavigatorModel navigator = new NavigatorModel(1, 3);
            ViewData["banner_url"] = "../assets/images/intro_background_menu2.png";
            return View(navigator);
        }

        [Route("Clinic/Shock")]
        public IActionResult Shock()
        {
            NavigatorModel navigator = new NavigatorModel(1, 4);
            ViewData["banner_url"] = "../assets/images/intro_background_menu2.png";
            return View(navigator);
        }

        [Route("Clinic/Retain")]
        public IActionResult Retain()
        {
            NavigatorModel navigator = new NavigatorModel(1, 5);
            ViewData["banner_url"] = "../assets/images/intro_background_menu2.png";
            return View(navigator);
        }
    }
    public class CommunityController : Controller
    {
        [OutputCache(NoStore = true, Duration = 0)]
        [Route("")]
        [Route("Community")]
        [Route("Community/Notice")]
        public IActionResult Notice()
        {
            NavigatorModel navigator = new NavigatorModel(2, 0);
            ViewData["banner_url"] = "../assets/images/intro_background_menu3.png";
            return View(navigator);
        }
        [Route("Community/Review")]
        public IActionResult Review()
        {
            NavigatorModel navigator = new NavigatorModel(2, 1);
            ViewData["banner_url"] = "../assets/images/intro_background_menu3.png";
            return View(navigator);
        }
        [Route("Community/News")]
        public IActionResult News()
        {
            NavigatorModel navigator = new NavigatorModel(2, 2);
            ViewData["banner_url"] = "../assets/images/intro_background_menu3.png";
            return View(navigator);
        }
    }
}

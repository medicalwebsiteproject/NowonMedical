using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OutputCaching;
using NowonMedical.Models;
using System.Diagnostics;

namespace NowonMedical.Controllers
{
    public class IndexController : Controller
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
        [Route("Index")]
        [Route("Index/Introduce")]
        public IActionResult Introduce()
        {
            return View();
        }
    }
}

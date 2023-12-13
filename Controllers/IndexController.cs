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
    }
}

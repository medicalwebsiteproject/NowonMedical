using Microsoft.AspNetCore.Mvc;
using NowonMedical.Models;
using System.Diagnostics;

namespace NowonMedical.Controllers
{
    public class IndexController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

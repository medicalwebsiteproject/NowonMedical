using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OutputCaching;
using Microsoft.EntityFrameworkCore;
using NowonMedical.Context;
using NowonMedical.Models;
using System.Data;

namespace NowonMedical.Controllers
{

    public class CommunityController : Controller
    {
        public NowonMedicalContext context { get; set; }

        public CommunityController(NowonMedicalContext context)
        {
            this.context = context;
        }

        [Route("/community/{boardType}/{page?}")]
        [HttpGet]
        public async Task<IActionResult> Index(string boardType, int? page)
        {
            NavigatorModel navigator = new NavigatorModel(2, 0);
            ViewData["banner_url"] = "../assets/images/intro_background_menu3.png";
			ViewData["main_banner_url"] = "../assets/images/intro_background.png";

            var boards = from board in context.communityBoards
                        where board.Type == boardType
                        select board;

            return View(navigator);
        }
    }
}

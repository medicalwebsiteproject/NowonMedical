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
        public IActionResult Index(string boardType, int? page)
        {
            ViewData["banner_url"] = "../assets/images/intro_background_menu3.png";
			ViewData["main_banner_url"] = "../assets/images/intro_background.png";

            int maxCount = context.communityBoards.Where(board => board.Type == boardType).Count();

            if(maxCount <= 20)
            {
                page = 0;
            }

            if(page == null || page < 1)
            {
                page = 1;
            }

            ViewBag.Boards = context.communityBoards.FromSql($"SELECT * FROM dbo.CommunityBoardTbl WHERE Type = {boardType} ORDER BY BoardId OFFSET {(page - 1) * 20} ROWS FETCH NEXT 20 ROWS ONLY").ToList();
            ViewBag.MaxPage = Math.Round((double)(maxCount / 20));

            int navigatorIdx = 0;

            if(boardType.ToLower() == "review")
            {
                ViewBag.Title = "진료후기";
                navigatorIdx = 1;
            } else if(boardType.ToLower() == "news")
            {
                ViewBag.Title = "보도자료";
                navigatorIdx = 2;
            } else
            {
                ViewBag.Title = "공지사항";
            }

			NavigatorModel navigator = new NavigatorModel(2, navigatorIdx);

			return View(navigator);
        }
    }
}

using Application.Services.CopyUser;
using ApplicationCompro.Services.GetListDG;
using ApplicationCompro.Services.ShowName;
using Endpoint.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Endpoint.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IGetListService _getMabda;
        private readonly IUserAccessService _userAccess;
        private readonly IShowName _showName;

        public HomeController(ILogger<HomeController> logger , IGetListService getMabda , IUserAccessService userAccess , IShowName showName)
        {
            _logger = logger;
            _getMabda = getMabda;
            _userAccess = userAccess;
            _showName = showName;
        }

        public IActionResult Index(string mabdaSearch = "", string maghsadSearch = "")
        {
            var mabdaList = _getMabda.Execute(mabdaSearch);
            var maghsadList = _getMabda.Execute(maghsadSearch);
                var model = new AccessViewModel
                {
                    MabdaList = mabdaList,
                    MaghsadList = maghsadList
                };
            return View(model);
        }

        [HttpPost]
        public IActionResult CopyUser(int sourceId, int targetId, bool copyOnlyView)
        {
            var result = _userAccess.CopyUserAccess(sourceId, targetId, copyOnlyView);
            return Json(result);
        }

        [HttpPost]
        public IActionResult RestoreUser(int targetId)
        {
            var result = _userAccess.RestorePreviousAccess(targetId);
            return Json(result);
        }

        [HttpGet]
        public IActionResult ShowName(int code)
        {
            var result = _showName.ShowName(new ShowNameDTO(), code);
            return Json(result);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TheRuhuahs_TandTNew.Interfaces.ServiceInterface;
using TheRuhuahs_TandTNew.Models;

namespace TheRuhuahs_TandTNew.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITouristCenterService _touristService;

        public HomeController(ILogger<HomeController> logger, ITouristCenterService touristCenterService )
        {
            _logger = logger;
            _touristService = touristCenterService;
        }

        public IActionResult Index()
        {
            var touristCenter = _touristService.GetTouristCenter(); 
            return View(touristCenter);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

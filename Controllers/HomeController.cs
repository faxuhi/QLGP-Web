using BusinessLayer.Bases;
using BusinessLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using QLGP_Web.Models;
using System.Diagnostics;

namespace QLGP_Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IOptions<Settings> _settings;
        private readonly IUserBase _user;
        public HomeController(ILogger<HomeController> logger, IOptions<Settings> settings, IUserBase user)
        {
            _logger = logger;
            _settings = settings;
            _user = user;
        }
        public IActionResult Index()
        {
            var userData = _user.SelectAll();

            return View(userData);
            //return View();
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

using BusinessLayer.Bases;
using BusinessLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace QLGP_Web.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IOptions<Settings> _settings;
        private readonly IUserBase _user;
        public UserController(ILogger<HomeController> logger, IOptions<Settings> settings, IUserBase user)
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
        public IActionResult Details(int id)
        {
            //Query db for id = 5
            id = 5;
            ViewBag.Id = id;

            return View();
        }
    }
}

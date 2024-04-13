
using BusinessLayer.Bases;
using BusinessLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace QLGP_Web.Controllers
{
    public class RoleController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IOptions<Settings> _settings;
        private readonly IRoleBase _role;
        public RoleController(ILogger<HomeController> logger, IOptions<Settings> settings, IRoleBase role)
        {
            _logger = logger;
            _settings = settings;
            _role = role;
        }
        public IActionResult Index()
        {
            var roleData = _role.SelectAll();

            return View(roleData);
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

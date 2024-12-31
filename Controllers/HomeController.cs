using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _appDbContext;
        public HomeController(ILogger<HomeController> logger, AppDbContext appDbContext)
        {
            _logger = logger;
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult route()
        {
            return View();
        }
        public IActionResult data_visualization()
        {
            return View();
        }
        public IActionResult page2()
        {
            return View();
        }
        public IActionResult traffic_issue()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        [HttpPost]
        public IActionResult SaveData(Contact contact)
        {
           if(ModelState.IsValid)
            {
                try
                {
                    _appDbContext.Add(contact);
                    _appDbContext.SaveChanges();
                    ViewBag.Message = "data saved succesfully";
                }
                catch (Exception ex)
                {
                    ViewBag.Message = "error occured";
                }

            }
           
            return View("Contact");
        }
    }
}

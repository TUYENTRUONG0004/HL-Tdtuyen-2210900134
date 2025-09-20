using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TdtuyenDy3.Models;


namespace TdtuyenDy3.Controllers
{
    public class TdtHomeController : Controller
    {
        private readonly ILogger<TdtHomeController> _logger;

        public TdtHomeController(ILogger<TdtHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult TdtIndex()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult TdtAbout()
        {
            return View();
        }

        public IActionResult TdtViewIf()
        {
            return View();
        }
        public IActionResult TdtViewLoop()
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
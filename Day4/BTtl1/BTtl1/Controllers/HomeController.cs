using System.Diagnostics;
using BTtl1.Models;
using Microsoft.AspNetCore.Mvc;

namespace BTtl1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // load sản phẩm mới nhất từ Action
            var products = new List<Product>
            {
                new Product{Id=1, Name="Nồi cơm điện cao tần Nagakawa NAG0102", Image="/images/noicom.jpg", Price=1000000},
                new Product{Id=2, Name="Nồi cơm điện cao tần Nagakawa NAG0102", Image="/images/noicom.jpg", Price=1000000},
                new Product{Id=3, Name="Nồi cơm điện cao tần Nagakawa NAG0102", Image="/images/noicom.jpg", Price=1000000},
            };
            return View(products);
        }

        // Action trả về Partial View Danh mục
        public IActionResult CategoryMenu()
        {
            var categories = new List<string> { "Điện tử", "Gia dụng", "Mẹ và bé", "Thời trang" };
            return PartialView("_CategoryMenu", categories);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

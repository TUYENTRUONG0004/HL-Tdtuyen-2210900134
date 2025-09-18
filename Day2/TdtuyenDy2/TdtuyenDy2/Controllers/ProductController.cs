using Microsoft.AspNetCore.Mvc;
using TdtuyenDy2.Models;

namespace TdtuyenDy2.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            ViewData["messageVD"] = "Dữ liệu lưu trong ViewData";
            ViewBag.messageVB = "Dữ liệu lưu trong ViewBag";
            TempData["messageTD"] = "Dữ liệu lưu trong TempData";
            return View();
        }
        public IActionResult GetProducts()
        {
            Product p = new Product
            {
                ProductId = 1,
                ProductName = "Trek 820 – 2016",
                YearRelease = 2016,
                Price = 379.99
            };

            ViewBag.product = p;
            ViewData["productVD"] = p;

            return View("~/Views/Product/GetProducts.cshtml");

        }
        public IActionResult GetAllProducts()
        {
            List<Product> products = new List<Product>
    {
        new Product{ ProductId = 1, ProductName = "Trek 820 – 2016", YearRelease = 2016, Price = 379.99},
        new Product{ ProductId = 2, ProductName = "Ritchey Timberwolf Frameset – 2016", YearRelease = 2016, Price = 749.99},
        new Product{ ProductId = 3, ProductName = "Surly Wednesday Frameset – 2016", YearRelease = 2016, Price = 999.99},
        new Product{ ProductId = 4, ProductName = "Trek Fuel EX 8 29 – 2016", YearRelease = 2016, Price = 2899.99},
        new Product{ ProductId = 5, ProductName = "Heller Shagamaw Frame – 2016", YearRelease = 2016, Price = 1320.93},
        // ... thêm các sản phẩm khác như trong tài liệu
    };

            ViewBag.products = products;
            return View("~/Views/Product/GetAllProducts.cshtml");
        }


    }
}

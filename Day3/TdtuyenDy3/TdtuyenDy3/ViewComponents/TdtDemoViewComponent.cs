using Microsoft.AspNetCore.Mvc;
using TdtuyenDy3.Models;

namespace TdtuyenDy3.ViewComponents
{
    public class TdtDemoViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<Category> categories = new List<Category>()
            {
                new Category { Id = 1, Name = "Điện tử" },
                new Category { Id = 2, Name = "Điện lạnh" },
                new Category { Id = 3, Name = "Đồ gia dụng" },
                new Category { Id = 4, Name = "Tiện ích" }
            };
            return View(categories);
        }
    }
}

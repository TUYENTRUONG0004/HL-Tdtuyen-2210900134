using Microsoft.AspNetCore.Mvc;
using BTtl1.Models; 

namespace BTtl1.ViewComponents
{
    public class HotProductViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var hotProducts = new List<Product>
            {
                new Product{Id=1, Name="Nồi cơm điện HOT Nagakawa", Image="/images/noicom.jpg", Price=2000000},
                new Product{Id=2, Name="Nồi cơm điện HOT Nagakawa", Image="/images/noicom.jpg", Price=2100000}
            };
            return View(hotProducts);
        }
    }
}

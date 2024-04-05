using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TRANTHEBAO1_2180605748.Models;

namespace TRANTHEBAO1_2180605748.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class ProductController : Controller
    {   
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        public IActionResult Index()
        {
            return View();
        }
    }
}

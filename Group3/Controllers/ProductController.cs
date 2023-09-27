using Group3.Reponsitory;
using Lib;
using Microsoft.AspNetCore.Mvc;

namespace Group3.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository productRepository;
        private ICat cat; 
        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        // GET: product
        public async Task<IActionResult> Index()
        {
            var product = await productRepository.GetAllAsync();
           
            return View(product);
        }
        [HttpGet]
        public async IActionResult Create()
        {
           List<CatMst> cate = (List<CatMst>) await cat.GetAllAsync();
            return View(cate);
        }
        [HttpPost]
        public async Task<IActionResult> Create(Product product  )
        {
            
            return View();
        }

    }
}

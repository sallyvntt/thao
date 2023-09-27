using Group3.Db;
using Group3.Reponsitory;
using Group3.Services;
using Lib;
using Microsoft.AspNetCore.Mvc;

namespace Group3.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository productRepository;
        private CatService cat;
        private DatabaseContext databaseContext;   
        public ProductController(IProductRepository productRepository,DatabaseContext databaseContext)
        {
            this.productRepository = productRepository;
            this.databaseContext =  databaseContext;
        }
        // GET: product
        public async Task<IActionResult> Index()
        {
            var product = await productRepository.GetAllAsync();
           
            return View(product);
        }
        [HttpGet]
      public  IActionResult Create()
        {
            IEnumerable<CatMst> catMst = databaseContext.CatMsts.ToList();
            ViewBag.CatMst = catMst;
          
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Product product  )
        {
            
            return View();
        }

    }
}

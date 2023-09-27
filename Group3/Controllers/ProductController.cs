using Group3.Db;
using Group3.Reponsitory;
using Group3.Services;
using Lib;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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
            List<CatMst> cate= databaseContext.CatMsts.ToList();
            // Chuyển đổi danh sách CatMst thành danh sách SelectListItem
            List<SelectListItem> categoryItems = cate.Select(c => new SelectListItem
            {
                Value = c.Cat_ID,
                Text = c.Cat_Name
            }).ToList();
            ViewBag.Categories = categoryItems;
            List<BrandMst>  brands = databaseContext.BrandMsts.ToList();
            List<SelectListItem> brandItem = brands.Select(c => new SelectListItem
            {
                Value= c.Brand_ID,
                Text = c.Brand_Type
            }).ToList();
            ViewBag.Brand_ID = brandItem;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Product product  )
        {
            productRepository.CreateAsync(product);
            return View();
        }

    }
}

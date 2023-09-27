using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Lib;
using Group3.Services;
using Group3.Reponsitory;

namespace Group3.Controllers
{
    public class ItemController : Controller
    {
        private readonly IItemRepository _itemRepository;

        public ItemController(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        // GET: Item
        public async Task<IActionResult> Index()
        {
            var items = await _itemRepository.GetAllItemsAsync();
            return View(items);
        }

        // GET: Item/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await _itemRepository.GetItemAsync(id);

            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        // GET: Item/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Item/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Style_Code,Pairs,Brand_ID,Quantity,Cat_ID,Prod_Quality,Certify_ID,Prod_ID,GoldType_ID,Gold_Wt,Stone_Wt,Net_Gold,Wstg_Per,Wstg,Tot_Gross_Wt,Gold_Rate,Gold_Amt,Gold_Making,Stone_Making,Other_Making,Tot_Making,MRP")] ItemMst item)
        {
            if (ModelState.IsValid)
            {
                await _itemRepository.CreateItemAsync(item);
                return RedirectToAction(nameof(Index));
            }
            return View(item);
        }

        // GET: Item/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await _itemRepository.GetItemAsync(id);

            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        // POST: Item/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Style_Code,Pairs,Brand_ID,Quantity,Cat_ID,Prod_Quality,Certify_ID,Prod_ID,GoldType_ID,Gold_Wt,Stone_Wt,Net_Gold,Wstg_Per,Wstg,Tot_Gross_Wt,Gold_Rate,Gold_Amt,Gold_Making,Stone_Making,Other_Making,Tot_Making,MRP")] ItemMst item)
        {
            if (id != item.Style_Code)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _itemRepository.UpdateItemAsync(item);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItemExists(item.Style_Code))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(item);
        }

        // GET: Item/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await _itemRepository.GetItemAsync(id);

            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        // POST: Item/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            await _itemRepository.DeleteItemAsync(id);
            return RedirectToAction(nameof(Index));
        }

        private bool ItemExists(string id)
        {
            return _itemRepository.GetItemAsync(id) != null;
        }
    }
}

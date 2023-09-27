using System;
using Lib;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Group3.Reponsitory;
using Group3.Db;

namespace Group3.Services
{
    public class ItemService : IItemRepository
    {
        private readonly DatabaseContext _context;

        public ItemService(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ItemMst>> GetAllItemsAsync()
        {
            return await _context.Items.ToListAsync();
        }

        public async Task<ItemMst> GetItemAsync(string styleCode)
        {
            return await _context.Items.FirstOrDefaultAsync(i => i.Style_Code == styleCode);
        }

        public async Task CreateItemAsync(ItemMst item)
        {
            _context.Items.Add(item);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateItemAsync(ItemMst item)
        {
            _context.Items.Update(item);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteItemAsync(string styleCode)
        {
            var item = await _context.Items.FirstOrDefaultAsync(i => i.Style_Code == styleCode);
            if (item != null)
            {
                _context.Items.Remove(item);
                await _context.SaveChangesAsync();
            }
        }
    }
}

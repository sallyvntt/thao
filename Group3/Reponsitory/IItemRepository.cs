using System;
using Lib;

namespace Group3.Reponsitory
{
    public interface IItemRepository
    {
        Task<IEnumerable<ItemMst>> GetAllItemsAsync();
        Task<ItemMst> GetItemAsync(string styleCode);
        Task CreateItemAsync(ItemMst item);
        Task UpdateItemAsync(ItemMst item);
        Task DeleteItemAsync(string styleCode);
    }
}


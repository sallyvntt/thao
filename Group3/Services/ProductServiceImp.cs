using Group3.Db;
using Group3.Reponsitory;
using Lib;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.IdentityModel.Tokens;
using System.Collections;

namespace Group3.Services
{
    public class ProductServiceImp : IProductRepository
    {
        
        private DatabaseContext db;
        private IBrand brand;
        public ProductServiceImp(DatabaseContext db)
        {
           this.db = db;
        }
        public async Task CreateAsync(Product product)
        {

        
            db.products.Add(product);
             await db.SaveChangesAsync();
        }

        public Task DeleteAsync(string product)
        {
            throw new NotImplementedException();
        }

        public async  Task<IEnumerable<Product>> GetAllAsync()
        {


            IEnumerable<Product> product
                =  await db.products.ToListAsync();



            return product;
        }

        public Task<Product> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Product product)
        {
            throw new NotImplementedException();
        }
    }
}

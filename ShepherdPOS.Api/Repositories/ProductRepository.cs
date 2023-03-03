
using Microsoft.EntityFrameworkCore;
using ShepherdPOS.Api.Repositories.Contracts;
using ShepherdPOS.Api.Data;
using ShepherdPOS.Api.Entities;

namespace ShepherdPOS.Api.Repositories
{
	public class ProductRepository :IProductRepository

    {
        private readonly ShepherdPosDbContext DbContext;

        public ProductRepository(ShepherdPosDbContext DbContext_)
        {
            this.DbContext = DbContext_;
        }
        public async Task<IEnumerable<ProductCategory>> GetCategories()
        {
            var categories = await this.DbContext.ProductCategories.ToListAsync();
           
            return categories; 
        
        }

        public async Task<ProductCategory> GetCategory(int id)
        {
            var category = await DbContext.ProductCategories.SingleOrDefaultAsync(c => c.Id == id);
            return category;
        }

        public async Task<Product> GetItem(int id)
        {
            var product = await DbContext.Products
                                .Include(p => p.ProductCategory)
                                .SingleOrDefaultAsync(p => p.Id == id);
            return product;
        }

        public async Task<IEnumerable<Product>> GetItems()
        {
            var products = await this.DbContext.Products
                                     .Include(p => p.ProductCategory).ToListAsync();

            return products;
        
        }

        public async Task<IEnumerable<Product>> GetItemsByCategory(int id)
        {
            var products = await this.DbContext.Products
                                     .Include(p => p.ProductCategory)
                                     .Where(p => p.CategoryId == id).ToListAsync();
            return products;
        }
    }
}


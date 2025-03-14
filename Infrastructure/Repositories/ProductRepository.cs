using Core.Entities;
using Core.IRepositories;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly StoreContext _context;

        public ProductRepository(StoreContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product?> GetProduct(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        public async Task<Product> CreateProduct(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task UpdateProduct(int id, Product product)
        {
            _context.Entry(product).State = EntityState.Modified;

            await _context.SaveChangesAsync();
        }

        public async Task DeleteProduct(int id)
        {
            var product = await GetProduct(id);

            if (product != null)
            {
                _context.Products.Remove(product);

                await _context.SaveChangesAsync();
            }
        }

        public bool ProductExists(int id)
        {
            return _context.Products.Any(x => x.Id == id);
        }
    }
}

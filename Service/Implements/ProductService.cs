using Core.Entities;
using Core.IRepositories;
using Service.Interfaces;

namespace Service.Implements
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepo;

        public ProductService(IProductRepository productRepo)
        {
            _productRepo = productRepo;
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _productRepo.GetProducts();
        }

        public async Task<Product?> GetProduct(int id)
        {
            return await _productRepo.GetProduct(id);
        }

        public async Task<Product> CreateProduct(Product product)
        {
            return await _productRepo.CreateProduct(product);
        }

        public async Task UpdateProduct(int id, Product product)
        {
            await _productRepo.UpdateProduct(id, product);
        }

        public async Task DeleteProduct(int id)
        {
            await _productRepo.DeleteProduct(id);
        }

        public bool ProductExists(int id)
        {
            return _productRepo.ProductExists(id);
        }
    }
}

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

        public void AddProduct(Product product)
        {
            _productRepo.AddProduct(product);
        }

        public void DeleteProduct(Product product)
        {
            _productRepo.DeleteProduct(product);
        }

        public async Task<IReadOnlyList<string>> GetBrandsAsync()
        {
            return await _productRepo.GetBrandsAsync();
        }

        public async Task<Product?> GetProductByIdAsync(int id)
        {
            return await _productRepo.GetProductByIdAsync(id);
        }

        public async Task<IReadOnlyList<Product>> GetProductsAsync(string? brand, string? type, string? sort)
        {
            return await _productRepo.GetProductsAsync(brand, type, sort);
        }

        public async Task<IReadOnlyList<string>> GetTypesAsync()
        {
            return await _productRepo.GetTypesAsync();
        }

        public bool ProductExists(int id)
        {
            return _productRepo.ProductExists(id);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _productRepo.SaveChangesAsync();
        }

        public void UpdateProduct(Product product)
        {
            _productRepo.UpdateProduct(product);
        }
    }
}

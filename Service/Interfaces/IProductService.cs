using Core.Entities;

namespace Service.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<Product?> GetProduct(int id);
        Task<Product> CreateProduct(Product product);
        Task UpdateProduct(int id, Product product);
        Task DeleteProduct(int id);
        bool ProductExists(int id);
    }
}

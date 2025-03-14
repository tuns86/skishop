using Core.Entities;

namespace Core.IRepositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<Product?> GetProduct(int id);
        Task<Product> CreateProduct(Product product);
        Task UpdateProduct(int id, Product product);
        Task DeleteProduct(int id);
        bool ProductExists(int id);
    }
}

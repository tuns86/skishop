using Core.Specifications;

namespace Service.Interfaces
{
    public interface ISpetificationService
    {
        ProductSpecification ProductSpecification(string? brand, string? type, string? sort);
        BrandListSpecification BrandListSpecification();
        TypeListSpecification TypeListSpecification();
    }
}

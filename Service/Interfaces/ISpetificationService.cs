using Core.Specifications;

namespace Service.Interfaces
{
    public interface ISpetificationService
    {
        ProductSpecification ProductSpecification(ProductSpecParams specParams);
        BrandListSpecification BrandListSpecification();
        TypeListSpecification TypeListSpecification();
    }
}

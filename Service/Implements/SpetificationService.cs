using Core.Entities;
using Core.ISpetification;
using Core.Specifications;
using Service.Interfaces;

namespace Service.Implements
{
    public class SpetificationService : ISpetificationService
    {
        public BrandListSpecification BrandListSpecification()
        {
            return new BrandListSpecification();
        }

        public ProductSpecification ProductSpecification(string? brand, string? type, string? sort)
        {
            return new ProductSpecification(brand, type, sort);
        }

        public TypeListSpecification TypeListSpecification()
        {
            return new TypeListSpecification();
        }
    }
}

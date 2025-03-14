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

        public ProductSpecification ProductSpecification(ProductSpecParams specParams)
        {
            return new ProductSpecification(specParams);
        }

        public TypeListSpecification TypeListSpecification()
        {
            return new TypeListSpecification();
        }
    }
}

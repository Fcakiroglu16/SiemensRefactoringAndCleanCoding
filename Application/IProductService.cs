using Domain;

namespace Application;

public interface IProductService
{
    void Add(ProductDto p);
    List<Product> GetAll();
    void Delete(ProductDto p);
}
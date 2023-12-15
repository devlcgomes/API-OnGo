using apiOnGo.DTO;
using apiOnGo.Models;

namespace apiOnGo.Interface.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> List();

        Product GetById(Guid id);

        Task<Product> Create(ProductDTO product);

        Task<Product> Update(Guid id, ProductDTO product);

        Task<Product> Delete (Guid id);
    }
}

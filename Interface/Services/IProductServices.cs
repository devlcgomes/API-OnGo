using apiOnGo.DTO;
using apiOnGo.Models;

namespace apiOnGo.Interface.Services
{
    public interface IProductServices
    {
        IEnumerable<Product> List();

        Product GetById(Guid id);
        Task<Product> Create(ProductDTO product);
        Task<Product> Update(Guid id, ProductDTO product);
        Task<Product> Delete(Guid id);
    }
}

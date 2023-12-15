using apiOnGo.DTO;
using apiOnGo.Interface.Repository;
using apiOnGo.Interface.Services;
using apiOnGo.Models;

namespace apiOnGo.Services
{
    public class ProductServices : IProductServices
    {

        private readonly IProductRepository _productRepository;

        public ProductServices(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }


        public async Task<Product> Create(ProductDTO product)
        {
            return await _productRepository.Create(product);
        }

        public async Task<Product> Delete(Guid id)
        {
            return await _productRepository.Delete(id);
        }

        public Product GetById(Guid id)
        {
            return _productRepository.GetById(id);
        }

        public IEnumerable<Product> List()
        {
            return _productRepository.List();
        }

        public async Task<Product> Update(Guid id, ProductDTO produto)
        {
            return await _productRepository.Update(id, produto);
        }
    }
}

using apiOnGo.Context;
using apiOnGo.DTO;
using apiOnGo.Interface.Repository;
using apiOnGo.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace apiOnGo.Repository
{
    public class ProductRepository : IProductRepository
    {

        private readonly DataContext _context;
        private readonly IMapper _mapper;


        public ProductRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Product> Create(ProductDTO produto)
        {
            try
            {
                var productEntity = _mapper.Map<Product>(produto);
                await _context.Products.AddAsync(productEntity);
                await _context.SaveChangesAsync();
                return productEntity;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public async Task<Product> Delete(Guid id)
        {
            try
            {
                var productEntity = await _context.Products.FirstOrDefaultAsync(x => x.Id == id);
                _context.Products.Remove(productEntity);
                await _context.SaveChangesAsync();
                return productEntity;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public Product GetByid(Guid id)
        {
            try
            {
                var productEntity = _context.Products.FirstOrDefault(x => x.Id == id);
                return productEntity;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Product GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> List()
        {
            try
            {
                return _context.Products.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Product> Update(Guid id, ProductDTO product)
        {
            try
            {
                var productEntity = await _context.Products.FirstOrDefaultAsync(x => x.Id == id);
                productEntity.Name = product.Name;
                await _context.SaveChangesAsync();
                return productEntity;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

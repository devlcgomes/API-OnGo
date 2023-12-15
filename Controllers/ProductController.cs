using apiOnGo.DTO;
using apiOnGo.Interface.Services;
using apiOnGo.Models;
using apiOnGo.Services;
using Microsoft.AspNetCore.Mvc;

namespace apiOnGo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductServices  _services;

        public ProductController(IProductServices services)
        {
            _services = services;
        }
        [HttpGet]

        public ActionResult<IEnumerable<Product>> List()
        {
            try
            {
                var products = _services.List();
                return Ok(products);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Product> GetById(Guid id)
        {
            try
            {
                var product = _services.GetById(id);

                if (product == null)
                {
                    return NotFound(); 
                }

                return Ok(product);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPost]
        public async Task<ActionResult<Product>> Create(ProductDTO product)
        {
            try
            {
                var productEntity = await _services.Create(product);
                return Ok(productEntity);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Product>> Update(Guid id, ProductDTO product)
        {
            try
            {
                var produtoEntity = await _services.Update(id, product);
                return Ok(produtoEntity);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(Guid id)
        {
            try
            {
                var productEntity = await _services.Delete(id);
                return Ok(productEntity);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }


}

using apiOnGo.DTO;
using apiOnGo.Interface.Services;
using apiOnGo.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace apiOnGo.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerServices _customerServices;
        private readonly IMapper _mapper;

        public CustomerController(ICustomerServices customerServices, IMapper mapper)
        {
            _customerServices = customerServices;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Customer>>List()
        {
            try
            {
                var customers = _customerServices.GetAll();
                return Ok(customers);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpGet("{id}")]
        public ActionResult<Customer> GetById(Guid id)
        {
            try
            {
                var usuario = _customerServices.Get(id);
                return Ok(usuario);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<Customer>> Create(CustomerDTO customer)
        {
            try
            {
                var customerEntity = await _customerServices.Create(customer);
                return Ok(customerEntity);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Customer>> Update(Guid id, CustomerDTO customer)
        {
            try
            {
                var customerEntity = await _customerServices.Update(customer, id);
                return Ok(customerEntity);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Customer>> Delete(Guid id)
        {
            try
            {
                await _customerServices.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

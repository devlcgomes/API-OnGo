using apiOnGo.Interface.Services;
using apiOnGo.Models;
using apiOnGo.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace apiOnGo.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class InventoryController : ControllerBase
    {

        private readonly IIventoryServices _services;

        public InventoryController(IIventoryServices services)
        {
            _services = services;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Inventory>> List()
        {
            try
            {
                var inventory = _services.List();
                return Ok(inventory);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet("{customerid}")]
        public ActionResult<IEnumerable<CustomerInventory>> ListInventory(string customerid)
        {
            try
            {
                var inventory = _services.ListInventory(customerid);
                return Ok(inventory);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPost]
        public async Task<ActionResult<CustomerInventory>> Create(string customerid, List<string> product)
        {
            try
            {
                var inventory = await _services.Create(customerid, product);
                return Ok(inventory);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpDelete("{customerid}/{productid}")]
        public async Task<ActionResult<bool>> Delete(string customerid, string productid)
        {
            try
            {
                var inventory = await _services.Delete(customerid, productid);
                return Ok(inventory);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}

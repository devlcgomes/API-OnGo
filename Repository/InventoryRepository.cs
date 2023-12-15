using apiOnGo.Context;
using apiOnGo.Interface.Repository;
using apiOnGo.Models;
using apiOnGo.ViewModels;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace apiOnGo.Repository
{
    public class InventoryRepository : IInventoryRepository
    {

        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public InventoryRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public async Task<CustomerInventory> Create(string customerid, List<string> product)
        {
            try
            {
                foreach (var i in product)
                {
                    var inventory = new Inventory();
                    inventory.CustomerId = customerid;
                    inventory.ProductId = i;
                    await _context.Inventories.AddAsync(inventory);
                    await _context.SaveChangesAsync();
                }
                //retorna o carrinho do usuario
                var inventoryCustomer = await _context.Inventories.Where(x => x.CustomerId == customerid).ToListAsync();
                var customerInventory = new CustomerInventory();
                customerInventory.InventoryId = inventoryCustomer[0].Id;
                customerInventory.CustomerId = customerid;
                var inventoryDTO = new List<Product>();
                foreach (var i in inventoryCustomer)
                {
                    var prd = _context.Products.Where(x => x.Id == Guid.Parse(i.ProductId)).FirstOrDefault();
                    inventoryDTO.Add(prd);
                }
                customerInventory.Inventory = inventoryDTO;
                return customerInventory;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> Delete(string customerid, string productid)
        {
            try
            {
                var inventory = await _context.Inventories.Where(x => x.CustomerId == customerid && x.ProductId == productid).FirstOrDefaultAsync();
                _context.Inventories.Remove(inventory);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<Inventory> List()
        {
            try
            {
                var inventory = _context.Inventories.ToList();
                return inventory;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<CustomerInventory> ListInventory(string customerid)
        {
            try
            {
                var inventory = _context.Inventories.Where(x => x.CustomerId == customerid).ToList();
                var inventoryDTO = new List<Product>();
                foreach (var i in inventory)
                {
                    var prd = _context.Products.Where(x => x.Id == Guid.Parse(i.ProductId)).FirstOrDefault();
                    inventoryDTO.Add(prd);
                }
                var customerInventory = new CustomerInventory();
                customerInventory.InventoryId = inventory[0].Id;
                customerInventory.CustomerId = customerid;
                customerInventory.Inventory = inventoryDTO;
                var list = new List<CustomerInventory>();
                list.Add(customerInventory);
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

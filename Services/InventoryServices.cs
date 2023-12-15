using apiOnGo.Context;
using apiOnGo.Interface.Repository;
using apiOnGo.Interface.Services;
using apiOnGo.Models;
using apiOnGo.ViewModels;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace apiOnGo.Services
{

    public class InventoryServices : IIventoryServices
    {
        private readonly IInventoryRepository _inventoryRepository;

        public InventoryServices(IInventoryRepository inventoryRepository)
        {
            _inventoryRepository = inventoryRepository;
        }

        public async Task<CustomerInventory> Create(string customerid, List<string> product)
        {
            return await _inventoryRepository.Create(customerid, product);
        }

        public async Task<bool> Delete(string customerid, string productid)
        {
            return await _inventoryRepository.Delete(customerid, productid);
        }

        public IEnumerable<Inventory> List()
        {
            return _inventoryRepository.List();
        }

        public IEnumerable<CustomerInventory>ListInventory(string customerid)
        {
            return _inventoryRepository.ListInventory(customerid);
        }
    }
}

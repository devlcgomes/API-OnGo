using apiOnGo.Models;
using apiOnGo.ViewModels;

namespace apiOnGo.Interface.Services
{
    public interface IIventoryServices
    {
        IEnumerable<Inventory> List();
        IEnumerable<CustomerInventory> ListInventory(string customerid);
        Task<CustomerInventory> Create(string customerid, List<string> product);
        Task<bool> Delete(string customerid, string productid);

    }
}

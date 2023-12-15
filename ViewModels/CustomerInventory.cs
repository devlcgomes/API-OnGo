using apiOnGo.Models;

namespace apiOnGo.ViewModels
{
    public class CustomerInventory
    {

        public Guid InventoryId { get; set; }

        public string CustomerId { get; set; }

        public List<Product> Inventory { get; set; }
    }
}

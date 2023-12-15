using apiOnGo.DTO;
using apiOnGo.Models;

namespace apiOnGo.Interface.Repository
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAll();
        Customer Get(Guid id);

        Task<Customer> Create(CustomerDTO customer);

        Task<Customer> Update(CustomerDTO customer, Guid Id);

        Task<bool> Delete(Guid id);
    }
}

using apiOnGo.DTO;
using apiOnGo.Helpers;
using apiOnGo.Interface.Repository;
using apiOnGo.Interface.Services;
using apiOnGo.Models;

namespace apiOnGo.Services
{
    public class CustomerServices : ICustomerServices
    {

        private readonly ICustomerRepository _repository;
        public CustomerServices(ICustomerRepository repository)
        {
            _repository = repository;
        }
        public async Task<Customer> Create(CustomerDTO customer)
        {
           

            try
            {
                var verifyDocument = IdDocumentValidation.IsCpf(customer.IdDocument);
                if (!verifyDocument)
                    throw new Exception("CPF inválido");
                return await _repository.Create(customer);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.Delete(id);
        }

        public Customer Get(Guid id)
        {
            return _repository.Get(id);
        }

        public IEnumerable<Customer> GetAll()
        {
            return _repository.GetAll();
        }

        public async Task<Customer> Update(CustomerDTO customer, Guid Id)
        {
            return await _repository.Update(customer, Id);
        }
    }
}

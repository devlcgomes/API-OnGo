using apiOnGo.Context;
using apiOnGo.DTO;
using apiOnGo.Interface.Repository;
using apiOnGo.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace apiOnGo.Repository
{
    public class CustomerRepository : ICustomerRepository
    {

        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public CustomerRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

        }
        public async Task<Customer> Create(CustomerDTO customer)
        {
            
            try
            {
                var cust = _mapper.Map<Customer>(customer);
                await _context.Customers.AddAsync(cust);
                await _context.SaveChangesAsync();
                return cust;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }     

        public async Task<bool> Delete(Guid id)
        {

            try
            {
                var cust = await _context.Customers.FindAsync(id);
                if (cust == null)
                {
                    throw new Exception("User Not Found");
                }
                else
                {
                    _context.Customers.Remove(cust);
                    await _context.SaveChangesAsync();
                    return true;
                }
            } catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            

        }

        public Customer Get(Guid id)
        {
            try
            {
                var cust = _context.Customers.Find(id);

                if(cust == null)
                {
                    throw new Exception("User not found");
                } else
                {
                    return cust;
                }
            } catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<Customer> GetAll()
        {

            try
            {
                var cust = _context.Customers.ToList();
                return cust;
            } catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
           
        }

        public async Task<Customer> Update(CustomerDTO customer, Guid Id)
        {
            try
            {
                var cust = await _context.Customers.FirstOrDefaultAsync(c => c.Id == Id);

                if (cust == null)
                {
                    throw new Exception("Invalid User");
                }

                _mapper.Map(customer, cust);

                _context.Entry(cust).State = EntityState.Modified;

                await _context.SaveChangesAsync();

                return cust;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }
    }
}

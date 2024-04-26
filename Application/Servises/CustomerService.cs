using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services
{
    public class CustomerService : IBaseService<Customer>
    {
        private readonly IBaseRepository<Customer> _customerRepository;

        public CustomerService(IBaseRepository<Customer> customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            Customer customer = await GetAsync(id);

            if (customer == null)
            {
                return false;
            }

            await _customerRepository.DeleteAsync(customer.Id);
            return true;
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            return await _customerRepository.GetAllAsync();
        }

        public async Task<Customer> GetAsync(Guid id)
        {
            return await _customerRepository.GetAsync(id);
        }

        public async Task<Customer> InsertAsync(Customer castomer)
        {
            return await _customerRepository.InsertAsync(castomer);
        }

        public async Task<bool> UpdateAsync(Customer customer)
        {
            var existingCustomer = await _customerRepository.GetAsync(customer.Id);

            if (existingCustomer is null)
            {
                return false;
            }

            existingCustomer.FullName = customer.FullName;
            existingCustomer.Address = customer.Address;
            existingCustomer.Phone = customer.Phone;
            existingCustomer.Gender = customer.Gender;

            return await _customerRepository.UpdateAsync(existingCustomer);
        }
    }
}

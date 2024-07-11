using CustomerAPI.Interfaces;

namespace CustomerAPI.Models
{
    public class CustomerRepo : ICustomerRepo
    {
        public List<Customer> GetAllCustomers()
        {
            return new List<Customer>
        {
            new Customer { Id = 1, FirstName = "sourav", LastName = "Bhatt" },
            new Customer { Id = 2, FirstName = "prachi", LastName = "Bhatt" },

        };
        }
    }
}

using ACM.DataAccess;
using ACM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ACM.BL
{
    public class CustomerRepository
    {
        private AddressRepository _addressRepository;

        public CustomerRepository()
        {
            _addressRepository = new AddressRepository();
        }      

        public Customer Retrieve(int customerId)
        {
            var customer = new Customer(customerId);
            
            if (customerId == 1)
            {
                customer.EmailAddress = "fbaggins@hobbit.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
                customer.AddressList = _addressRepository.RetriveByCustomerId(customerId).ToList();
            }
            return customer;
        }

        public bool Save(Customer customer)
        {
            return true;
        }
    }
}

using ACM.BL.AddressClassess;
using ACM.BL.CustomerClassess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL.RepositoryClassess
{
    public class CustomerRepository
    {
        private AddressRepository addressRepository { get; set; }

        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }

        /// <summary>
        /// Saves the current customer
        /// </summary>
        /// <returns></returns>
        public bool Save(Customer customer)
        {
            //TODO: write the code that saves the current customer
            return true;
        }

        /// <summary>
        /// Get customer by ID
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Customer Retrieve(int customerId)
        {
            // TODO: write the code that retreives customer according to id

            // Create the instance of the Customer class
            Customer customer = new Customer(customerId);

            //int homeId = 1;
            //int workId = 2;
            //customer.HomeAddress = addressRepository.Retrieve(homeId);
            //customer.WorkAddress = addressRepository.Retrieve(workId);

            List<Address> addresses = addressRepository.RetrieveByCustomerId(customerId).ToList();
            foreach (var addr in addresses)
            {
                if (addr.AddressType == AddressType.HOME)
                {
                    customer.HomeAddress = addr;
                }

                if (addr.AddressType == AddressType.WORK)
                {
                    customer.WorkAddress = addr;
                }
            }

            // Temporary hard coded values to return
            // a populated customer
            if (customerId == 1)
            {
                customer.Email = "email@mail.com";
                customer.FirstName = "John";
                customer.LastName = "Doe";
            }

            return customer;
        }

        /// <summary>
        /// Get list of customers customer
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public IEnumerable<Customer> Retrieve()
        {
            //TODO: write the code that retreives list of customers
            return new List<Customer>();
        }

    }
}

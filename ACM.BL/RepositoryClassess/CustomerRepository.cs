using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        /// <summary>
        /// Saves the current customer
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            //TODO: write the code that saves the current customer
            return true;
        }

        /// <summary>
        /// Get customer by ID
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Customer Retreive(int customerId)
        {
            //TODO: write the code that retreives customer according to id

            //Create the instance of the Customer class
            Customer customer = null;

            //Temporary code
            if (customerId == 1)
            {
                customer = new Customer(1);
                customer.Email = "email@mail.com";
                customer.FirstName = "John";
                customer.LastName = "Doe";
            }
            else
            {
                customer = new Customer();
            }

            return customer;
        }

        /// <summary>
        /// Get list of customers customer
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public IEnumerable<Customer> Retreive()
        {
            //TODO: write the code that retreives list of customers
            return new List<Customer>();
        }

    }
}

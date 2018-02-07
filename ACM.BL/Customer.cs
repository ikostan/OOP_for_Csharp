using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    /// <summary>
    /// Customer entity definition
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Backing fields
        /// </summary>
        private string _firstName;
        private string _lastName;
        private string _email;
        private string _homeAddress;
        private string _workAddress;
        private int _customerId;

        /// <summary>
        /// No args constructor
        /// </summary>
        public Customer()
        {
            Customer.InstanceCount += 1;
        }

        /// <summary>
        /// Parameterised constructor
        /// </summary>
        public Customer(string firstName, 
                        string lastName, 
                        string email)
        {
            Customer.InstanceCount += 1;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
        }

        /// <summary>
        /// Parameterised constructor
        /// </summary>
        public Customer(string firstName, 
                        string lastName, 
                        string email, 
                        string homeAddress, 
                        string workAddress)
        {
            Customer.InstanceCount += 1;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
        }

        /// <summary>
        /// Counter -> shows how many instances of Customer type were created
        /// </summary>
        public static int InstanceCount { get; private set; }

        /// <summary>
        /// Customer first name
        /// </summary>
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value.Trim()))
                {
                    throw new FormatException(ErrorMessages.EmptyFirstName);
                }
                else
                {
                    _firstName = CapitaliseFirstLetter(value);
                }
            }
        }

        /// <summary>
        /// Customer last name
        /// </summary>
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value.Trim()))
                {
                    throw new FormatException(ErrorMessages.EmptyLastName);
                }
                else
                {
                    _lastName = CapitaliseFirstLetter(value);
                }
            }
        }

        /// <summary>
        /// Capitalise first letter. 
        /// The rest of the name will be in lower case. 
        /// Trim extra spaces (start/end).
        /// </summary>
        /// <returns></returns>
        private string CapitaliseFirstLetter(string name)
        {
            return name.Trim().First().ToString().ToUpper() + name.Trim().ToLower().Substring(1);
        }

        /// <summary>
        /// Customer Full Name. Getter only.
        /// </summary>
        public string FullName
        {
            get
            {
                string fullName = LastName;

                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }

                    fullName += FirstName;
                }

                return fullName;
            }
        }

        /// <summary>
        /// Email address
        /// </summary>
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        /// <summary>
        /// Home address
        /// </summary>
        public string HomeAddress
        {
            get { return _homeAddress; }
            set { _homeAddress = value; }
        }

        /// <summary>
        /// Work address
        /// </summary>
        public string WorkAddress
        {
            get { return _workAddress; }
            set { _workAddress = value; }
        }

        /// <summary>
        /// Customer id
        /// </summary>
        public int CustomerId
        {
            get => _customerId;
            private set => _customerId = value;
        }

        /// <summary>
        /// Validation method.
        /// Verifies if FirstName/LastName/Email.
        /// Returns false in case one of them is null or empty.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(FirstName))
            {
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(LastName))
            {
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(Email))
            {
                isValid = false;
            }

            return isValid;
        }

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
            return new Customer();
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

        //End of Class
    }
}

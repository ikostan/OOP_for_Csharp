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
        private Address _homeAddress;
        private Address _workAddress;
        private int _customerId;

        /// <summary>
        /// No args constructor
        /// </summary>
        public Customer()
        {
            Customer.InstanceCount += 1;
        }

        /// <summary>
        /// No args constructor
        /// </summary>
        public Customer(int id) : this()
        {
            this.CustomerId = id;
        }

        /// <summary>
        /// Parameterised constructor
        /// </summary>
        public Customer(string firstName, 
                        string lastName, 
                        string email) : this()
        {
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
                        Address homeAddress, 
                        Address workAddress) : this(firstName, lastName, email)
        {
            this.HomeAddress = homeAddress;
            this.WorkAddress = workAddress;
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
            set
            {
                if (value.Trim().Contains('@') && 
                    value.Trim().Contains('.'))
                {
                    _email = value.Trim().ToLower();
                }
                else
                {
                    throw new FormatException(ErrorMessages.InvalidEmail);
                }
            }
        }

        /// <summary>
        /// Home address
        /// </summary>
        public Address HomeAddress
        {
            get { return _homeAddress; }
            set
            {
                _homeAddress = (value.AddressType == AddressType.HOME) 
                    ? value : throw new FormatException(ErrorMessages.InvalidAddressType);
            }
        }

        /// <summary>
        /// Work address
        /// </summary>
        public Address WorkAddress
        {
            get { return _workAddress; }
            set
            { _workAddress = (value.AddressType == AddressType.WORK) 
                    ? value : throw new FormatException(ErrorMessages.InvalidAddressType);
            }
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

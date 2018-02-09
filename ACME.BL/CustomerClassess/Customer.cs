using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACME.BL.AddressClassess;
using ACME.BL.HelperClassess;
using ACME.COMMON;

namespace ACME.BL.CustomerClassess
{
    /// <summary>
    /// Customer entity definition
    /// </summary>
    public class Customer : ILoggable, IEquatable<Customer>
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
        /// Holds customer type.
        /// Enum.
        /// </summary>
        public CustomerType CustomerType { get; set; }

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
                    _firstName = StringHandler.CapitaliseFirstLetter(value);
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
                    _lastName = StringHandler.CapitaliseFirstLetter(value);
                }
            }
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
            {
                _workAddress = (value.AddressType == AddressType.WORK)
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
        /// Returns customer full name
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return FullName + ": " + CustomerId;
        }

        /// <summary>
        /// Returns log info
        /// </summary>
        /// <returns></returns>
        public string Log()
        {
            return this.ToString();
        }


        public bool Equals(Customer other)
        {
            if (this.HomeAddress.AddressType == other.HomeAddress.AddressType &&
                this.HomeAddress.AddressId == other.HomeAddress.AddressId &&
                this.HomeAddress.City == other.HomeAddress.City &&
                this.HomeAddress.Country == other.HomeAddress.Country &&
                this.HomeAddress.PostalCode == other.HomeAddress.PostalCode &&
                this.HomeAddress.State == other.HomeAddress.State &&
                this.HomeAddress.StreetLine1 == other.HomeAddress.StreetLine1 &&
                this.HomeAddress.StreetLine2 == other.HomeAddress.StreetLine2 &&
                //
                this.WorkAddress.AddressType == other.WorkAddress.AddressType &&
                this.WorkAddress.AddressId == other.WorkAddress.AddressId &&
                this.WorkAddress.City == other.WorkAddress.City &&
                this.WorkAddress.Country == other.WorkAddress.Country &&
                this.WorkAddress.PostalCode == other.WorkAddress.PostalCode &&
                this.WorkAddress.State == other.WorkAddress.State &&
                this.WorkAddress.StreetLine1 == other.WorkAddress.StreetLine1 &&
                this.WorkAddress.StreetLine2 == other.WorkAddress.StreetLine2

                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //End of Class
    }
}

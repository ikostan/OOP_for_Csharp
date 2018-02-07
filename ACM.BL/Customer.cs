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
        /// Customer first name
        /// </summary>
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = CapitaliseFirstLetter(value); }
        }

        /// <summary>
        /// Customer last name
        /// </summary>
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = CapitaliseFirstLetter(value); }
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
            get { return LastName + ", " + FirstName; }
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

        //End of Class
    }
}

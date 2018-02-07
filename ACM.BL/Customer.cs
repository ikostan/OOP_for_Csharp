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

        /// <summary>
        /// Customer first name
        /// </summary>
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        /// <summary>
        /// Customer last name
        /// </summary>
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        /// <summary>
        /// Email address
        /// </summary>
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        //Home address
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

        //End of Class
    }
}

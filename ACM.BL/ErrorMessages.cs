using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    /// <summary>
    /// Contains error messages
    /// </summary>
    public class ErrorMessages
    {
        /// <summary>
        /// Empty first name error
        /// </summary>
        public static string EmptyFirstName
        {
            get { return "First name can not be empty!"; }
        }

        /// <summary>
        /// Empty last name error
        /// </summary>
        public static string EmptyLastName
        {
            get { return "Last name can not be empty!"; }
        }

        /// <summary>
        /// Invalid email address
        /// </summary>
        public static string InvalidEmail
        {
            get { return "Invalid email address!"; }
        }

        public static string InvalidAddressType
        {
            get { return "Invalid address type!"; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    /// <summary>
    /// Holds Address Data
    /// </summary>
    class Address
    {
        private string _streetLine1;
        private string _streetLine2;
        private string _city;
        private string _state;
        private string _postalCode;
        private string _country;
        private AddressType _addressType;

        public string StreetLine1 { get => _streetLine1; set => _streetLine1 = value; }
        public string StreetLine2 { get => _streetLine2; set => _streetLine2 = value; }
        public string City { get => _city; set => _city = value; }
        public string State { get => _state; set => _state = value; }
        public string PostalCode { get => _postalCode; set => _postalCode = value; }
        public string Country { get => _country; set => _country = value; }
        public AddressType AddressType { get => _addressType; set => _addressType = value; }
    }
}

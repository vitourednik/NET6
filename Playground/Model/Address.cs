using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.Model
{
    internal class Address
    {
        public Address()
        {

        }
        public Address(string _street,string _city,int _postcode,string _country)
        {
            Street = _street;
            City = _city;
            PostCode = _postcode;
            Country = _country;
        }

        public string Street { get; set; }
        public string City { get; set; }
        public int PostCode { get; set; }
        public string Country { get; set; }
    }
}

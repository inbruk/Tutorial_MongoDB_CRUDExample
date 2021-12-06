using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    public class AddressModel
    {
        public String StreetAddress { set; get; }
        public String City { set; get; }
        public String Region { set; get; }
        public String PostalCode { set; get; }

        public AddressModel(String strAdr, String city, String region, String pCode)
        {
            StreetAddress = strAdr;
            City = city;
            Region = region;
            PostalCode = pCode;
        }
    }
}

using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class PersonModel
    {
        [BsonId]
        public Guid Id { get; set; } // _id
        public String FirstName { set; get; }
        public String LastName { set; get; }
        public AddressModel PrimaryAddress { set; get; }

        public PersonModel(String fn, String ln, AddressModel pam)
        {
            FirstName = fn; 
            LastName = ln;
            PrimaryAddress = pam;
        }
    }
}

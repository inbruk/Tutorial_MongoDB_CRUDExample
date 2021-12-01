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

        [BsonElement("dob")]
        public DateTime DateOfBirth { set; get; }

        public PersonModel(String fn, String ln, AddressModel pam, DateTime dtb)
        {
            FirstName = fn; 
            LastName = ln;
            PrimaryAddress = pam;
            DateOfBirth = dtb;
        }
    }
}

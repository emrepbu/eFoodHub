using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eFoodHub.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string Locality { get; set; }
        public int ZipCode { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public int UserId { get; set; }

    }
}

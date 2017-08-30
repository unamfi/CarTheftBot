using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarTheft.Models
{
    public class AddressModel
    {
        public string uuid { get; set; }
        public string Street { get; set; }
        public string Colonia { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}
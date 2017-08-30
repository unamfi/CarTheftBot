using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarTheft.Models
{
    public class VehicleModel
    {
        public string uuid { get; set; }
        public string LicensePlate { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string Insurance_Carrier { get; set; }
        public string LossDate { get; set; }
        public string LossLocation { get; set; }
        public string RecoveryDate { get; set; }
        public string RecoveryLocation { get; set; }
        public string RecoveryType { get; set; }
        public string VehicleOwner { get; set; }
        public string VehicleVin { get; set; }
        public AddressModel Address { get; set; }
        public AccountModel Account { get; set; }
        public ActivityModel Activity { get; set; }
    }
}
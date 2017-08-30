using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarTheft.Models
{
    public class ReportModel
    {
        public string uuid { get; set; }
        public string Description { get; set; }
        public string LossDate { get; set; }
        public string LossCause { get; set; }
        public string InjuredPeople { get; set; }
        public string DeadPeople { get; set; }
        public string ReportedBy { get; set; }
        public string Vehicles { get; set; }
        public string History { get; set; }
        public AccountModel Account { get; set; }
        public VehicleModel Vehicle { get; set; }
        public ActivityModel Activity { get; set; }
    }
}